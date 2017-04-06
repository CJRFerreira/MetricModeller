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
namespace MetricModeller
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();


        }
        int count = 0;
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public List<string> ReadLanguage()
        {
            List<string> languageList = new List<string>();
            using (var fs = File.OpenRead(Application.StartupPath  +@"\\language_prod.csv"))
            using (var reader = new StreamReader(fs))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    languageList.Add(values[0]);

                }
            }
            return languageList;
        }

        public List<string> ReadLevel()
        {
            List<string> levelList = new List<string>();
            using (var fs = File.OpenRead(Path.Combine(Environment.CurrentDirectory, "@//language_prod.csv")))
            using (var reader = new StreamReader(fs))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    levelList.Add(values[1]);

                }
            }
            return levelList;
        }

        public List<string> ReadStatmentsPerFP()
        {
            List<string> statmentsPerFPList = new List<string>();
            using (var fs = File.OpenRead("*/language_prod.csv"))
            using (var reader = new StreamReader(fs))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    statmentsPerFPList.Add(values[2]);

                }
            }
            return statmentsPerFPList;
        }

        public string[] ConvertLanguage()
        {
            ReadLanguage();
            string[] language = new string[ReadLanguage().ToArray().Length-1];
            for(int i=1;i<language.Length-1;i+=1)
            {
                language[i - 1] = ReadLanguage().ToArray()[i];
            }
            return language;
               

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void FinalCalculateBtn_Click(object sender, EventArgs e)
        {
            textBox2.Text = ConvertLanguage()[487];
        }

        private void SizingGb_Enter(object sender, EventArgs e)
        {

        }
    }
}
