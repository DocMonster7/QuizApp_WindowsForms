using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace QuizApp_WindowsForms
{
    
    public partial class QuizMaster : Form
    {
        private static string _Path = string.Empty;
        private static bool DEBUG = true;
        static string answer1, answer2, answer3;
        static int score=0;
       
        public QuizMaster()
        {
            Write("Initialization");
            InitializeComponent();
            Write("Initilization Complete");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Write("Form Quiz Master Loaded");
            JObject questionDump = JObject.Parse(File.ReadAllText(@"data.json"));
            Write("data.json laoded in the form");
            Load_Questions(questionDump);
            Write("Questions Loaded onto the tab control");

        }

       

        private void Load_Questions(JObject questionDump)
        {
            Random random = new Random();
            int randomQuestion = random.Next(1,10),temp;
            Write("First Question Loading");
            lbQuestion1.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion11.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer1 = rbQuestion11.Text;
            rbQuestion12.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion13.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion14.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];
            Write("First Question Loaded");
            temp = random.Next(1, 10);
            if (temp != randomQuestion)
            {
                randomQuestion = temp;
            }
            Write("Second Question Loading");
            lbQuestion2.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion24.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer2 = rbQuestion24.Text;
            rbQuestion21.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion23.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion22.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];
            Write("Second Question Loaded");
            temp = random.Next(1, 10);
            if (temp != randomQuestion)
            {
                randomQuestion = temp;
            }

            Write("Third Question Loading");
            lbQuestion3.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion33.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer3 = rbQuestion33.Text;
            rbQuestion32.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion31.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion34.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];
            Write("Third Question Loaded");

        }

        private void tpQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void btNext1_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion2;
            Write("btNext1 Clicked");
        }

        private void rbQuestion14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void tbQuestion2_Click(object sender, EventArgs e)
        {

        }

        private void btBackQuestion2_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion1;
            Write("btBackQuestion2 clicked");
        }

        private void btNextQuestion2_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion3;
            Write("btNextQuestion2 clicked");
        }

        private void rbQuestion24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbQuestion2_Click(object sender, EventArgs e)
        {

        }

        private void tpQuestion3_Click(object sender, EventArgs e)
        {

        }

        private void btBackQuestion3_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion2;
            Write("btBackQuestion3 Clicked");
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //submit is here
            // rb correct answers option 11 24 33

            Write("Submit button clicked");
            
            if (rbQuestion11.Checked)
            {
                score++;
            }
            if (rbQuestion24.Checked)
            {
                score++;
                
            }
            if (rbQuestion33.Checked)
            {
                score++;
            }
            Write("Score Calculated");
            if (score == 0)
            {
                MessageBox.Show("Your Final Score Zero Better Luck Next Time");
            }
            else if (score>0&&score<3)
            {
                MessageBox.Show("You Scored " + score);
            }
            else
            {
                MessageBox.Show("Wow Amazing you got everything Right. You are a Movie Wizard");
            }
            Write("Message displayed");
            JObject questionDump = JObject.Parse(File.ReadAllText(@"data.json"));
            Write("data.json Loaded");
            Load_Questions(questionDump);
            Write("Questions Loaded onto the tab control");
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion1;
            Write("Tab switched");
        }

        private void rbQuestion34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuestion31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbQuestion3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void Write(string msg)
        {
            _Path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(Path.Combine(_Path, "log.txt")))
                {
                    Log(msg, w);
                }
                if (DEBUG)
                    Console.WriteLine(msg);
            }
            catch (Exception e)
            {
                //Handle
                MessageBox.Show("Error While Logging : " + Convert.ToString(e));

            }
        }

        static private void Log(string msg, TextWriter w)
        {
            try
            {
                w.Write(Environment.NewLine);
                w.Write("[{0} {1}]", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.Write("\t");
                w.WriteLine(" {0}", msg);
                w.WriteLine("-----------------------");
            }
            catch (Exception e)
            {
                //Handle
                MessageBox.Show("Error While writing the log : " + Convert.ToString(e));
            }
        }
    }

    
}
