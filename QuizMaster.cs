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
        static string answer1, answer2, answer3;
        static int score=0;
        public QuizMaster()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JObject questionDump = JObject.Parse(File.ReadAllText(@"data.json"));
            Load_Questions(questionDump);
            
        }

       

        private void Load_Questions(JObject questionDump)
        {
            Random random = new Random();
            int randomQuestion = random.Next(1,10),temp;
            
            lbQuestion1.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion11.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer1 = rbQuestion11.Text;
            rbQuestion12.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion13.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion14.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];

            temp = random.Next(1, 10);
            if (temp != randomQuestion)
            {
                randomQuestion = temp;
            }

            lbQuestion2.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion24.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer2 = rbQuestion24.Text;
            rbQuestion21.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion23.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion22.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];

            temp = random.Next(1, 10);
            if (temp != randomQuestion)
            {
                randomQuestion = temp;
            }


            lbQuestion3.Text = (string)questionDump["results"][randomQuestion]["question"];
            rbQuestion33.Text = (string)questionDump["results"][randomQuestion]["correct_answer"];
            answer3 = rbQuestion33.Text;
            rbQuestion32.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][0];
            rbQuestion31.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][2];
            rbQuestion34.Text = (string)questionDump["results"][randomQuestion]["incorrect_answers"][1];


        }

        private void tpQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void btNext1_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion2;
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
        }

        private void btNextQuestion2_Click(object sender, EventArgs e)
        {
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion3;
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
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //submit is here
            // rb correct answers option 11 24 33
            
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
            JObject questionDump = JObject.Parse(File.ReadAllText(@"data.json"));
            Load_Questions(questionDump);
            this.tcQuizMasterDisplay.SelectedTab = this.tpQuestion1;
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
    }
}
