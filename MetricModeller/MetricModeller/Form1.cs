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
            using (var fs = File.OpenRead(@"language_prod.csv"))
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
            using (var fs = File.OpenRead(@"language_prod.csv"))
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

        public List<string> ReadSPerFP()
        {
            List<string> sPerFPList = new List<string>();
            using (var fs = File.OpenRead(@"language_prod.csv"))
            using (var reader = new StreamReader(fs))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    sPerFPList.Add(values[2]);

                }
            }
            return sPerFPList;
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
            textBox2.Text = ReadLevel().ToArray()[1].ToString();
        }
    }
}
