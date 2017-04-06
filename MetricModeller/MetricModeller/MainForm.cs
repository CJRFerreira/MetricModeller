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
            if (!AdjustedFPTb.Text.Equals("") && !LanguageCb.Text.Equals(""))
            {
            }
            else
            {
                OutputRtb.Text = "Please fully complete the form presented on the left!\n\nThis includes both the Function Point and Language requirements.";
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
            int unadjustedFP = CalculateUserInputs() + CalculateUserOutputs() + CalculateUserInquires() + CalculateFiles() + CalculateInterfaces();

            UnadjustedFPTb.Text = unadjustedFP.ToString();
            AdjustedFPTb.Text = (unadjustedFP * 0.65).ToString();
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