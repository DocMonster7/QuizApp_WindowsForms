
namespace QuizApp_WindowsForms
{
    partial class QuizMaster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcQuizMasterDisplay = new System.Windows.Forms.TabControl();
            this.tpQuestion1 = new System.Windows.Forms.TabPage();
            this.btNext1 = new System.Windows.Forms.Button();
            this.rbQuestion14 = new System.Windows.Forms.RadioButton();
            this.rbQuestion13 = new System.Windows.Forms.RadioButton();
            this.rbQuestion12 = new System.Windows.Forms.RadioButton();
            this.rbQuestion11 = new System.Windows.Forms.RadioButton();
            this.lbQuestion1 = new System.Windows.Forms.Label();
            this.tpQuestion2 = new System.Windows.Forms.TabPage();
            this.btBackQuestion2 = new System.Windows.Forms.Button();
            this.btNextQuestion2 = new System.Windows.Forms.Button();
            this.rbQuestion24 = new System.Windows.Forms.RadioButton();
            this.rbQuestion23 = new System.Windows.Forms.RadioButton();
            this.rbQuestion22 = new System.Windows.Forms.RadioButton();
            this.rbQuestion21 = new System.Windows.Forms.RadioButton();
            this.lbQuestion2 = new System.Windows.Forms.Label();
            this.tpQuestion3 = new System.Windows.Forms.TabPage();
            this.btBackQuestion3 = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.rbQuestion34 = new System.Windows.Forms.RadioButton();
            this.rbQuestion33 = new System.Windows.Forms.RadioButton();
            this.rbQuestion32 = new System.Windows.Forms.RadioButton();
            this.rbQuestion31 = new System.Windows.Forms.RadioButton();
            this.lbQuestion3 = new System.Windows.Forms.Label();
            this.tcQuizMasterDisplay.SuspendLayout();
            this.tpQuestion1.SuspendLayout();
            this.tpQuestion2.SuspendLayout();
            this.tpQuestion3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuizMasterDisplay
            // 
            this.tcQuizMasterDisplay.Controls.Add(this.tpQuestion1);
            this.tcQuizMasterDisplay.Controls.Add(this.tpQuestion2);
            this.tcQuizMasterDisplay.Controls.Add(this.tpQuestion3);
            this.tcQuizMasterDisplay.Location = new System.Drawing.Point(12, 12);
            this.tcQuizMasterDisplay.Name = "tcQuizMasterDisplay";
            this.tcQuizMasterDisplay.SelectedIndex = 0;
            this.tcQuizMasterDisplay.Size = new System.Drawing.Size(775, 425);
            this.tcQuizMasterDisplay.TabIndex = 0;
            this.tcQuizMasterDisplay.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpQuestion1
            // 
            this.tpQuestion1.Controls.Add(this.btNext1);
            this.tpQuestion1.Controls.Add(this.rbQuestion14);
            this.tpQuestion1.Controls.Add(this.rbQuestion13);
            this.tpQuestion1.Controls.Add(this.rbQuestion12);
            this.tpQuestion1.Controls.Add(this.rbQuestion11);
            this.tpQuestion1.Controls.Add(this.lbQuestion1);
            this.tpQuestion1.Location = new System.Drawing.Point(4, 24);
            this.tpQuestion1.Name = "tpQuestion1";
            this.tpQuestion1.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuestion1.Size = new System.Drawing.Size(767, 397);
            this.tpQuestion1.TabIndex = 0;
            this.tpQuestion1.Text = "Question 1";
            this.tpQuestion1.UseVisualStyleBackColor = true;
            this.tpQuestion1.Click += new System.EventHandler(this.tpQuestion1_Click);
            // 
            // btNext1
            // 
            this.btNext1.Location = new System.Drawing.Point(279, 254);
            this.btNext1.Name = "btNext1";
            this.btNext1.Size = new System.Drawing.Size(75, 23);
            this.btNext1.TabIndex = 5;
            this.btNext1.Text = "Next";
            this.btNext1.UseVisualStyleBackColor = true;
            this.btNext1.Click += new System.EventHandler(this.btNext1_Click);
            // 
            // rbQuestion14
            // 
            this.rbQuestion14.AutoSize = true;
            this.rbQuestion14.Location = new System.Drawing.Point(403, 184);
            this.rbQuestion14.Name = "rbQuestion14";
            this.rbQuestion14.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion14.TabIndex = 4;
            this.rbQuestion14.Text = "radioButton4";
            this.rbQuestion14.UseVisualStyleBackColor = true;
            this.rbQuestion14.CheckedChanged += new System.EventHandler(this.rbQuestion14_CheckedChanged);
            // 
            // rbQuestion13
            // 
            this.rbQuestion13.AutoSize = true;
            this.rbQuestion13.Location = new System.Drawing.Point(403, 148);
            this.rbQuestion13.Name = "rbQuestion13";
            this.rbQuestion13.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion13.TabIndex = 3;
            this.rbQuestion13.Text = "radioButton3";
            this.rbQuestion13.UseVisualStyleBackColor = true;
            this.rbQuestion13.CheckedChanged += new System.EventHandler(this.rbQuestion13_CheckedChanged);
            // 
            // rbQuestion12
            // 
            this.rbQuestion12.AutoSize = true;
            this.rbQuestion12.Location = new System.Drawing.Point(149, 184);
            this.rbQuestion12.Name = "rbQuestion12";
            this.rbQuestion12.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion12.TabIndex = 2;
            this.rbQuestion12.Text = "radioButton2";
            this.rbQuestion12.UseVisualStyleBackColor = true;
            this.rbQuestion12.CheckedChanged += new System.EventHandler(this.rbQuestion12_CheckedChanged);
            // 
            // rbQuestion11
            // 
            this.rbQuestion11.AutoSize = true;
            this.rbQuestion11.Checked = true;
            this.rbQuestion11.Location = new System.Drawing.Point(149, 148);
            this.rbQuestion11.Name = "rbQuestion11";
            this.rbQuestion11.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion11.TabIndex = 1;
            this.rbQuestion11.TabStop = true;
            this.rbQuestion11.Text = "radioButton1";
            this.rbQuestion11.UseVisualStyleBackColor = true;
            this.rbQuestion11.CheckedChanged += new System.EventHandler(this.rbQuestion11_CheckedChanged);
            // 
            // lbQuestion1
            // 
            this.lbQuestion1.AutoSize = true;
            this.lbQuestion1.Location = new System.Drawing.Point(243, 105);
            this.lbQuestion1.Name = "lbQuestion1";
            this.lbQuestion1.Size = new System.Drawing.Size(0, 15);
            this.lbQuestion1.TabIndex = 0;
            this.lbQuestion1.Click += new System.EventHandler(this.lbQuestion1_Click);
            // 
            // tpQuestion2
            // 
            this.tpQuestion2.Controls.Add(this.btBackQuestion2);
            this.tpQuestion2.Controls.Add(this.btNextQuestion2);
            this.tpQuestion2.Controls.Add(this.rbQuestion24);
            this.tpQuestion2.Controls.Add(this.rbQuestion23);
            this.tpQuestion2.Controls.Add(this.rbQuestion22);
            this.tpQuestion2.Controls.Add(this.rbQuestion21);
            this.tpQuestion2.Controls.Add(this.lbQuestion2);
            this.tpQuestion2.Location = new System.Drawing.Point(4, 24);
            this.tpQuestion2.Name = "tpQuestion2";
            this.tpQuestion2.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuestion2.Size = new System.Drawing.Size(767, 397);
            this.tpQuestion2.TabIndex = 1;
            this.tpQuestion2.Text = "Question 2";
            this.tpQuestion2.UseVisualStyleBackColor = true;
            this.tpQuestion2.Click += new System.EventHandler(this.tbQuestion2_Click);
            // 
            // btBackQuestion2
            // 
            this.btBackQuestion2.Location = new System.Drawing.Point(264, 259);
            this.btBackQuestion2.Name = "btBackQuestion2";
            this.btBackQuestion2.Size = new System.Drawing.Size(75, 23);
            this.btBackQuestion2.TabIndex = 12;
            this.btBackQuestion2.Text = "Back";
            this.btBackQuestion2.UseVisualStyleBackColor = true;
            this.btBackQuestion2.Click += new System.EventHandler(this.btBackQuestion2_Click);
            // 
            // btNextQuestion2
            // 
            this.btNextQuestion2.Location = new System.Drawing.Point(364, 259);
            this.btNextQuestion2.Name = "btNextQuestion2";
            this.btNextQuestion2.Size = new System.Drawing.Size(75, 23);
            this.btNextQuestion2.TabIndex = 11;
            this.btNextQuestion2.Text = "Next";
            this.btNextQuestion2.UseVisualStyleBackColor = true;
            this.btNextQuestion2.Click += new System.EventHandler(this.btNextQuestion2_Click);
            // 
            // rbQuestion24
            // 
            this.rbQuestion24.AutoSize = true;
            this.rbQuestion24.Location = new System.Drawing.Point(436, 191);
            this.rbQuestion24.Name = "rbQuestion24";
            this.rbQuestion24.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion24.TabIndex = 10;
            this.rbQuestion24.Text = "radioButton4";
            this.rbQuestion24.UseVisualStyleBackColor = true;
            this.rbQuestion24.CheckedChanged += new System.EventHandler(this.rbQuestion24_CheckedChanged);
            // 
            // rbQuestion23
            // 
            this.rbQuestion23.AutoSize = true;
            this.rbQuestion23.Location = new System.Drawing.Point(436, 155);
            this.rbQuestion23.Name = "rbQuestion23";
            this.rbQuestion23.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion23.TabIndex = 9;
            this.rbQuestion23.Text = "radioButton3";
            this.rbQuestion23.UseVisualStyleBackColor = true;
            this.rbQuestion23.CheckedChanged += new System.EventHandler(this.rbQuestion23_CheckedChanged);
            // 
            // rbQuestion22
            // 
            this.rbQuestion22.AutoSize = true;
            this.rbQuestion22.Location = new System.Drawing.Point(159, 191);
            this.rbQuestion22.Name = "rbQuestion22";
            this.rbQuestion22.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion22.TabIndex = 8;
            this.rbQuestion22.Text = "radioButton2";
            this.rbQuestion22.UseVisualStyleBackColor = true;
            this.rbQuestion22.CheckedChanged += new System.EventHandler(this.rbQuestion22_CheckedChanged);
            // 
            // rbQuestion21
            // 
            this.rbQuestion21.AutoSize = true;
            this.rbQuestion21.Checked = true;
            this.rbQuestion21.Location = new System.Drawing.Point(159, 155);
            this.rbQuestion21.Name = "rbQuestion21";
            this.rbQuestion21.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion21.TabIndex = 7;
            this.rbQuestion21.TabStop = true;
            this.rbQuestion21.Text = "radioButton1";
            this.rbQuestion21.UseVisualStyleBackColor = true;
            this.rbQuestion21.CheckedChanged += new System.EventHandler(this.rbQuestion21_CheckedChanged);
            // 
            // lbQuestion2
            // 
            this.lbQuestion2.AutoSize = true;
            this.lbQuestion2.Location = new System.Drawing.Point(159, 111);
            this.lbQuestion2.Name = "lbQuestion2";
            this.lbQuestion2.Size = new System.Drawing.Size(38, 15);
            this.lbQuestion2.TabIndex = 6;
            this.lbQuestion2.Text = "label1";
            this.lbQuestion2.Click += new System.EventHandler(this.lbQuestion2_Click);
            // 
            // tpQuestion3
            // 
            this.tpQuestion3.Controls.Add(this.btBackQuestion3);
            this.tpQuestion3.Controls.Add(this.btSubmit);
            this.tpQuestion3.Controls.Add(this.rbQuestion34);
            this.tpQuestion3.Controls.Add(this.rbQuestion33);
            this.tpQuestion3.Controls.Add(this.rbQuestion32);
            this.tpQuestion3.Controls.Add(this.rbQuestion31);
            this.tpQuestion3.Controls.Add(this.lbQuestion3);
            this.tpQuestion3.Location = new System.Drawing.Point(4, 24);
            this.tpQuestion3.Name = "tpQuestion3";
            this.tpQuestion3.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuestion3.Size = new System.Drawing.Size(767, 397);
            this.tpQuestion3.TabIndex = 2;
            this.tpQuestion3.Text = "Question 3";
            this.tpQuestion3.UseVisualStyleBackColor = true;
            this.tpQuestion3.Click += new System.EventHandler(this.tpQuestion3_Click);
            // 
            // btBackQuestion3
            // 
            this.btBackQuestion3.Location = new System.Drawing.Point(266, 262);
            this.btBackQuestion3.Name = "btBackQuestion3";
            this.btBackQuestion3.Size = new System.Drawing.Size(75, 23);
            this.btBackQuestion3.TabIndex = 12;
            this.btBackQuestion3.Text = "Back";
            this.btBackQuestion3.UseVisualStyleBackColor = true;
            this.btBackQuestion3.Click += new System.EventHandler(this.btBackQuestion3_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(347, 262);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 11;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // rbQuestion34
            // 
            this.rbQuestion34.AutoSize = true;
            this.rbQuestion34.Location = new System.Drawing.Point(429, 191);
            this.rbQuestion34.Name = "rbQuestion34";
            this.rbQuestion34.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion34.TabIndex = 10;
            this.rbQuestion34.Text = "radioButton4";
            this.rbQuestion34.UseVisualStyleBackColor = true;
            this.rbQuestion34.CheckedChanged += new System.EventHandler(this.rbQuestion34_CheckedChanged);
            // 
            // rbQuestion33
            // 
            this.rbQuestion33.AutoSize = true;
            this.rbQuestion33.Location = new System.Drawing.Point(429, 155);
            this.rbQuestion33.Name = "rbQuestion33";
            this.rbQuestion33.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion33.TabIndex = 9;
            this.rbQuestion33.Text = "radioButton3";
            this.rbQuestion33.UseVisualStyleBackColor = true;
            this.rbQuestion33.CheckedChanged += new System.EventHandler(this.rbQuestion33_CheckedChanged);
            // 
            // rbQuestion32
            // 
            this.rbQuestion32.AutoSize = true;
            this.rbQuestion32.Location = new System.Drawing.Point(166, 191);
            this.rbQuestion32.Name = "rbQuestion32";
            this.rbQuestion32.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion32.TabIndex = 8;
            this.rbQuestion32.Text = "radioButton2";
            this.rbQuestion32.UseVisualStyleBackColor = true;
            this.rbQuestion32.CheckedChanged += new System.EventHandler(this.rbQuestion32_CheckedChanged);
            // 
            // rbQuestion31
            // 
            this.rbQuestion31.AutoSize = true;
            this.rbQuestion31.Checked = true;
            this.rbQuestion31.Location = new System.Drawing.Point(166, 155);
            this.rbQuestion31.Name = "rbQuestion31";
            this.rbQuestion31.Size = new System.Drawing.Size(94, 19);
            this.rbQuestion31.TabIndex = 7;
            this.rbQuestion31.TabStop = true;
            this.rbQuestion31.Text = "radioButton1";
            this.rbQuestion31.UseVisualStyleBackColor = true;
            this.rbQuestion31.CheckedChanged += new System.EventHandler(this.rbQuestion31_CheckedChanged);
            // 
            // lbQuestion3
            // 
            this.lbQuestion3.AutoSize = true;
            this.lbQuestion3.Location = new System.Drawing.Point(166, 120);
            this.lbQuestion3.Name = "lbQuestion3";
            this.lbQuestion3.Size = new System.Drawing.Size(38, 15);
            this.lbQuestion3.TabIndex = 6;
            this.lbQuestion3.Text = "label1";
            this.lbQuestion3.Click += new System.EventHandler(this.lbQuestion3_Click);
            // 
            // QuizMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcQuizMasterDisplay);
            this.Name = "QuizMaster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcQuizMasterDisplay.ResumeLayout(false);
            this.tpQuestion1.ResumeLayout(false);
            this.tpQuestion1.PerformLayout();
            this.tpQuestion2.ResumeLayout(false);
            this.tpQuestion2.PerformLayout();
            this.tpQuestion3.ResumeLayout(false);
            this.tpQuestion3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuizMasterDisplay;
        private System.Windows.Forms.TabPage tpQuestion2;
        private System.Windows.Forms.TabPage tpQuestion3;
        private System.Windows.Forms.TabPage tpQuestion1;
        private System.Windows.Forms.Button btNext1;
        private System.Windows.Forms.RadioButton rbQuestion14;
        private System.Windows.Forms.RadioButton rbQuestion13;
        private System.Windows.Forms.RadioButton rbQuestion12;
        private System.Windows.Forms.RadioButton rbQuestion11;
        private System.Windows.Forms.Label lbQuestion1;
        private System.Windows.Forms.Button btBackQuestion2;
        private System.Windows.Forms.Button btNextQuestion2;
        private System.Windows.Forms.RadioButton rbQuestion24;
        private System.Windows.Forms.RadioButton rbQuestion23;
        private System.Windows.Forms.RadioButton rbQuestion22;
        private System.Windows.Forms.RadioButton rbQuestion21;
        private System.Windows.Forms.Label lbQuestion2;
        private System.Windows.Forms.Button btBackQuestion3;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.RadioButton rbQuestion34;
        private System.Windows.Forms.RadioButton rbQuestion33;
        private System.Windows.Forms.RadioButton rbQuestion32;
        private System.Windows.Forms.RadioButton rbQuestion31;
        private System.Windows.Forms.Label lbQuestion3;
    }
}

