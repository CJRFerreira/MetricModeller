using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetricModeller.Types;
using System.Drawing.Drawing2D;

namespace MetricModeller
{
    /// <summary>
    /// For Individual Functions, implement checks for if the user inputted a value. If so, use it;
    /// If not, ignore it and use a default.
    /// </summary>
    public partial class MainForm : Form
    {
        public List<Language> Languages;

        public MainForm()
        {
            InitializeComponent();
            Languages = ReadLanguage();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var lang in Languages)
            {
                LanguageCb.Items.Add(lang);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.LightBlue,
                                                                       Color.Purple,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        public List<Language> ReadLanguage()
        {
            List<Language> languages = new List<Language>();
            string[] splitLine;

            try
            {
                using (StreamReader reader = new StreamReader(Application.StartupPath + @"\\language_prod.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        splitLine = reader.ReadLine().Split(',');

                        languages.Add(new Language(splitLine[0], (int)(double.Parse(splitLine[1])), (int)(double.Parse(splitLine[2]))));
                    }

                    reader.Close();
                }
            }
            catch (IOException e)
            {
                OutputRtb.Text = e.Message;
            }

            return languages;
        }

        private void FinalCalculateBtn_Click(object sender, EventArgs e)
        {
            OutputRtb.Text = "";
            try
            {
                ErrorLbl.Text = "";
                if (!AdjustedFPTb.Text.Equals("") && !LanguageCb.Text.Equals(""))
                {
                    decimal EstLOC = decimal.Parse(CodePerFPTb.Text) * decimal.Parse(AdjustedFPTb.Text);
                    OutputRtb.Text += $"Estimated Lines of Code: {EstLOC}\n";

                    double Effort = 0;

                    if (AverageTeamSkillCB.Text.Equals("Beginner"))
                    {
                        Effort = Math.Round((((3.6 * Math.Pow(Convert.ToDouble(EstLOC), 1.20)) * 100) / 1) / 10000, 2);
                    }
                    else if (AverageTeamSkillCB.Text.Equals("Intermediate"))
                    {
                        Effort = Math.Round((((3.6 * Math.Pow(Convert.ToDouble(EstLOC), 1.20)) * 100) / 2) / 10000, 2);
                    }
                    else if (AverageTeamSkillCB.Text.Equals("Expert"))
                    {
                        Effort = Math.Round((((3.6 * Math.Pow(Convert.ToDouble(EstLOC), 1.20)) * 100) / 3) / 10000, 2);
                    }
                    else
                    {
                        Effort = Math.Round((((3.6 * Math.Pow(Convert.ToDouble(EstLOC), 1.20)) * 100) / 2) / 10000, 2);
                    }

                    decimal projectHours = 0;
                    if (!AverageTeamSkillCB.Text.Equals(""))
                    {
                        if (AverageTeamSkillCB.Text.Equals("Beginner"))
                        {
                            projectHours = EstLOC / 125;
                        }
                        else if (AverageTeamSkillCB.Text.Equals("Intermediate"))
                        {
                            projectHours = EstLOC / 250;
                        }
                        else if (AverageTeamSkillCB.Text.Equals("Expert"))
                        {
                            projectHours = EstLOC / 500;
                        }
                    }
                    else
                    {
                        projectHours = EstLOC / 250;
                    }

                    //Decide percetanges to take away or add to project hours based on the amount of people working on the project
                    double estimatedTimeDifference;
                    if (AmtTeamMembersNud.Value == 1)
                    {
                        estimatedTimeDifference = 1;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    else if (AmtTeamMembersNud.Value >= 2 && AmtTeamMembersNud.Value <= 3)
                    {
                        estimatedTimeDifference = 0.96;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    else if (AmtTeamMembersNud.Value >= 4 && AmtTeamMembersNud.Value <= 5)
                    {
                        estimatedTimeDifference = 0.84;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    else if(AmtTeamMembersNud.Value >= 6 && AmtTeamMembersNud.Value <= 8)
                    {
                        estimatedTimeDifference = 0.82;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    else if (AmtTeamMembersNud.Value >= 9 && AmtTeamMembersNud.Value <= 11)
                    {
                        estimatedTimeDifference = 1.21;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    else
                    {
                        estimatedTimeDifference = 1.20;
                        projectHours *= (decimal)(estimatedTimeDifference);
                    }
                    /*----*/

                    projectHours = projectHours * 24;
                    OutputRtb.Text += $"Estimated Project Hours: {Math.Round(projectHours)}\n";

                    decimal projectedCost = 0;
                    if (AverageTeamCostNud.Value > 0)
                    {
                        projectedCost = (projectHours * AverageTeamCostNud.Value) * AmtTeamMembersNud.Value;
                    }
                    else
                    {
                        projectedCost = (projectHours * 20) * AmtTeamMembersNud.Value;
                    }
                    OutputRtb.Text += $"Estimated Project Cost: {projectedCost:C}\n";
                    OutputRtb.Text += $"Effort Level (Performed by worker in one month): {Effort}\n";
                }
                else
                {
                    OutputRtb.Text = "Please fully complete the form presented on the left!\n\nThis includes both the Function Point and Language requirements.";
                    ErrorLbl.Text = "There are either empty or incorrect fields";
                }
            }
            catch (Exception)
            {
                ErrorLbl.Text = "There are either empty or incorrect fields";
            }
        }

        private void LanguageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language currLang = Languages.Where(lang => lang.Name.Equals(LanguageCb.Text.ToString())).First();

            LangaugeLevelTb.Text = currLang.Level.ToString();
            CodePerFPTb.Text = currLang.LinesPerFP.ToString();
        }

        private void CalculateFPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLbl.Text = "";
                int unadjustedFP = CalculateUserInputs() + CalculateUserOutputs() + CalculateUserInquires() + CalculateFiles() + CalculateInterfaces();

                UnadjustedFPTb.Text = unadjustedFP.ToString();
                AdjustedFPTb.Text = (unadjustedFP * 0.65).ToString();
            }
            catch(Exception)
            {
                ErrorLbl.Text = "There are either empty or incorrect fields";
            }
        }

        private int CalculateUserInputs()
        {
            return int.Parse(UserInputsTb.Text) * (int)InputComplexityNud.Value;
        }

        private int CalculateUserOutputs()
        {
            return int.Parse(UserOutputsTb.Text) * (int)OutputComplexityNud.Value;
        }

        private int CalculateUserInquires()
        {
            return int.Parse(UserInquiresTb.Text) * (int)InquiryComplexityNud.Value;
        }

        private int CalculateFiles()
        {
            return int.Parse(FileTb.Text) * (int)FileComplexityNud.Value;
        }

        private int CalculateInterfaces()
        {
            return int.Parse(InterfaceTb.Text) * (int)ApiComplexityNud.Value;
        }
    }
}