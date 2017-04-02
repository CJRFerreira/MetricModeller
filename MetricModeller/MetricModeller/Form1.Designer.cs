namespace MetricModeller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SizingGb = new System.Windows.Forms.GroupBox();
            this.SizingTc = new System.Windows.Forms.TabControl();
            this.FuncPointTp = new System.Windows.Forms.TabPage();
            this.OutputComplexityNud = new System.Windows.Forms.NumericUpDown();
            this.OutputComplexityLbl = new System.Windows.Forms.Label();
            this.InputComplexityNud = new System.Windows.Forms.NumericUpDown();
            this.InputComplexityLbl = new System.Windows.Forms.Label();
            this.UserOutputsTb = new System.Windows.Forms.TextBox();
            this.UserInputsTb = new System.Windows.Forms.TextBox();
            this.UserOutputsLbl = new System.Windows.Forms.Label();
            this.UserInputsLbl = new System.Windows.Forms.Label();
            this.CodeLinesTp = new System.Windows.Forms.TabPage();
            this.AdditonalQuestionClb = new System.Windows.Forms.CheckedListBox();
            this.FinalCalculateBtn = new System.Windows.Forms.Button();
            this.OutputRtb = new System.Windows.Forms.RichTextBox();
            this.InquiryComplexityNud = new System.Windows.Forms.NumericUpDown();
            this.InquiryComplexityLbl = new System.Windows.Forms.Label();
            this.UserInquiresTb = new System.Windows.Forms.TextBox();
            this.UserInquiresLbl = new System.Windows.Forms.Label();
            this.FileComplexityNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FileTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FpTotalLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguageLbl = new System.Windows.Forms.Label();
            this.LanguageCb = new System.Windows.Forms.ComboBox();
            this.SizingGb.SuspendLayout();
            this.SizingTc.SuspendLayout();
            this.FuncPointTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputComplexityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputComplexityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InquiryComplexityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileComplexityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SizingGb
            // 
            this.SizingGb.Controls.Add(this.SizingTc);
            this.SizingGb.Location = new System.Drawing.Point(13, 13);
            this.SizingGb.Name = "SizingGb";
            this.SizingGb.Size = new System.Drawing.Size(559, 511);
            this.SizingGb.TabIndex = 0;
            this.SizingGb.TabStop = false;
            this.SizingGb.Text = "Sizing Method";
            // 
            // SizingTc
            // 
            this.SizingTc.Controls.Add(this.FuncPointTp);
            this.SizingTc.Controls.Add(this.CodeLinesTp);
            this.SizingTc.Location = new System.Drawing.Point(7, 20);
            this.SizingTc.Name = "SizingTc";
            this.SizingTc.SelectedIndex = 0;
            this.SizingTc.Size = new System.Drawing.Size(546, 485);
            this.SizingTc.TabIndex = 0;
            // 
            // FuncPointTp
            // 
            this.FuncPointTp.Controls.Add(this.LanguageCb);
            this.FuncPointTp.Controls.Add(this.LanguageLbl);
            this.FuncPointTp.Controls.Add(this.numericUpDown1);
            this.FuncPointTp.Controls.Add(this.label3);
            this.FuncPointTp.Controls.Add(this.textBox2);
            this.FuncPointTp.Controls.Add(this.label4);
            this.FuncPointTp.Controls.Add(this.FpTotalLbl);
            this.FuncPointTp.Controls.Add(this.textBox1);
            this.FuncPointTp.Controls.Add(this.FileComplexityNud);
            this.FuncPointTp.Controls.Add(this.label1);
            this.FuncPointTp.Controls.Add(this.FileTb);
            this.FuncPointTp.Controls.Add(this.label2);
            this.FuncPointTp.Controls.Add(this.InquiryComplexityNud);
            this.FuncPointTp.Controls.Add(this.InquiryComplexityLbl);
            this.FuncPointTp.Controls.Add(this.UserInquiresTb);
            this.FuncPointTp.Controls.Add(this.UserInquiresLbl);
            this.FuncPointTp.Controls.Add(this.OutputComplexityNud);
            this.FuncPointTp.Controls.Add(this.OutputComplexityLbl);
            this.FuncPointTp.Controls.Add(this.InputComplexityNud);
            this.FuncPointTp.Controls.Add(this.InputComplexityLbl);
            this.FuncPointTp.Controls.Add(this.UserOutputsTb);
            this.FuncPointTp.Controls.Add(this.UserInputsTb);
            this.FuncPointTp.Controls.Add(this.UserOutputsLbl);
            this.FuncPointTp.Controls.Add(this.UserInputsLbl);
            this.FuncPointTp.Location = new System.Drawing.Point(4, 22);
            this.FuncPointTp.Name = "FuncPointTp";
            this.FuncPointTp.Padding = new System.Windows.Forms.Padding(3);
            this.FuncPointTp.Size = new System.Drawing.Size(538, 459);
            this.FuncPointTp.TabIndex = 0;
            this.FuncPointTp.Text = "Function Points";
            this.FuncPointTp.UseVisualStyleBackColor = true;
            // 
            // OutputComplexityNud
            // 
            this.OutputComplexityNud.Location = new System.Drawing.Point(345, 50);
            this.OutputComplexityNud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OutputComplexityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OutputComplexityNud.Name = "OutputComplexityNud";
            this.OutputComplexityNud.Size = new System.Drawing.Size(120, 20);
            this.OutputComplexityNud.TabIndex = 7;
            this.OutputComplexityNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OutputComplexityLbl
            // 
            this.OutputComplexityLbl.AutoSize = true;
            this.OutputComplexityLbl.Location = new System.Drawing.Point(227, 53);
            this.OutputComplexityLbl.Name = "OutputComplexityLbl";
            this.OutputComplexityLbl.Size = new System.Drawing.Size(120, 13);
            this.OutputComplexityLbl.TabIndex = 6;
            this.OutputComplexityLbl.Text = "User Output Complexity:";
            // 
            // InputComplexityNud
            // 
            this.InputComplexityNud.Location = new System.Drawing.Point(345, 15);
            this.InputComplexityNud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InputComplexityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputComplexityNud.Name = "InputComplexityNud";
            this.InputComplexityNud.Size = new System.Drawing.Size(120, 20);
            this.InputComplexityNud.TabIndex = 5;
            this.InputComplexityNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputComplexityLbl
            // 
            this.InputComplexityLbl.AutoSize = true;
            this.InputComplexityLbl.Location = new System.Drawing.Point(227, 18);
            this.InputComplexityLbl.Name = "InputComplexityLbl";
            this.InputComplexityLbl.Size = new System.Drawing.Size(112, 13);
            this.InputComplexityLbl.TabIndex = 4;
            this.InputComplexityLbl.Text = "User Input Complexity:";
            // 
            // UserOutputsTb
            // 
            this.UserOutputsTb.Location = new System.Drawing.Point(110, 50);
            this.UserOutputsTb.Name = "UserOutputsTb";
            this.UserOutputsTb.Size = new System.Drawing.Size(100, 20);
            this.UserOutputsTb.TabIndex = 3;
            // 
            // UserInputsTb
            // 
            this.UserInputsTb.Location = new System.Drawing.Point(110, 15);
            this.UserInputsTb.Name = "UserInputsTb";
            this.UserInputsTb.Size = new System.Drawing.Size(100, 20);
            this.UserInputsTb.TabIndex = 2;
            // 
            // UserOutputsLbl
            // 
            this.UserOutputsLbl.AutoSize = true;
            this.UserOutputsLbl.Location = new System.Drawing.Point(10, 53);
            this.UserOutputsLbl.Name = "UserOutputsLbl";
            this.UserOutputsLbl.Size = new System.Drawing.Size(94, 13);
            this.UserOutputsLbl.TabIndex = 1;
            this.UserOutputsLbl.Text = "# of User Outputs:";
            // 
            // UserInputsLbl
            // 
            this.UserInputsLbl.AutoSize = true;
            this.UserInputsLbl.Location = new System.Drawing.Point(10, 18);
            this.UserInputsLbl.Name = "UserInputsLbl";
            this.UserInputsLbl.Size = new System.Drawing.Size(86, 13);
            this.UserInputsLbl.TabIndex = 0;
            this.UserInputsLbl.Text = "# of User Inputs:";
            // 
            // CodeLinesTp
            // 
            this.CodeLinesTp.Location = new System.Drawing.Point(4, 22);
            this.CodeLinesTp.Name = "CodeLinesTp";
            this.CodeLinesTp.Padding = new System.Windows.Forms.Padding(3);
            this.CodeLinesTp.Size = new System.Drawing.Size(538, 459);
            this.CodeLinesTp.TabIndex = 1;
            this.CodeLinesTp.Text = "Lines of Code";
            this.CodeLinesTp.UseVisualStyleBackColor = true;
            // 
            // AdditonalQuestionClb
            // 
            this.AdditonalQuestionClb.FormattingEnabled = true;
            this.AdditonalQuestionClb.Location = new System.Drawing.Point(579, 18);
            this.AdditonalQuestionClb.Name = "AdditonalQuestionClb";
            this.AdditonalQuestionClb.Size = new System.Drawing.Size(247, 259);
            this.AdditonalQuestionClb.TabIndex = 1;
            // 
            // FinalCalculateBtn
            // 
            this.FinalCalculateBtn.Location = new System.Drawing.Point(579, 284);
            this.FinalCalculateBtn.Name = "FinalCalculateBtn";
            this.FinalCalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.FinalCalculateBtn.TabIndex = 2;
            this.FinalCalculateBtn.Text = "Calculate";
            this.FinalCalculateBtn.UseVisualStyleBackColor = true;
            // 
            // OutputRtb
            // 
            this.OutputRtb.Location = new System.Drawing.Point(579, 314);
            this.OutputRtb.Name = "OutputRtb";
            this.OutputRtb.Size = new System.Drawing.Size(247, 200);
            this.OutputRtb.TabIndex = 3;
            this.OutputRtb.Text = "";
            // 
            // InquiryComplexityNud
            // 
            this.InquiryComplexityNud.Location = new System.Drawing.Point(345, 87);
            this.InquiryComplexityNud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InquiryComplexityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InquiryComplexityNud.Name = "InquiryComplexityNud";
            this.InquiryComplexityNud.Size = new System.Drawing.Size(120, 20);
            this.InquiryComplexityNud.TabIndex = 11;
            this.InquiryComplexityNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InquiryComplexityLbl
            // 
            this.InquiryComplexityLbl.AutoSize = true;
            this.InquiryComplexityLbl.Location = new System.Drawing.Point(227, 90);
            this.InquiryComplexityLbl.Name = "InquiryComplexityLbl";
            this.InquiryComplexityLbl.Size = new System.Drawing.Size(94, 13);
            this.InquiryComplexityLbl.TabIndex = 10;
            this.InquiryComplexityLbl.Text = "Inquiry Complexity:";
            // 
            // UserInquiresTb
            // 
            this.UserInquiresTb.Location = new System.Drawing.Point(110, 87);
            this.UserInquiresTb.Name = "UserInquiresTb";
            this.UserInquiresTb.Size = new System.Drawing.Size(100, 20);
            this.UserInquiresTb.TabIndex = 9;
            // 
            // UserInquiresLbl
            // 
            this.UserInquiresLbl.AutoSize = true;
            this.UserInquiresLbl.Location = new System.Drawing.Point(10, 90);
            this.UserInquiresLbl.Name = "UserInquiresLbl";
            this.UserInquiresLbl.Size = new System.Drawing.Size(94, 13);
            this.UserInquiresLbl.TabIndex = 8;
            this.UserInquiresLbl.Text = "# of User Inquires:";
            // 
            // FileComplexityNud
            // 
            this.FileComplexityNud.Location = new System.Drawing.Point(345, 122);
            this.FileComplexityNud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FileComplexityNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FileComplexityNud.Name = "FileComplexityNud";
            this.FileComplexityNud.Size = new System.Drawing.Size(120, 20);
            this.FileComplexityNud.TabIndex = 15;
            this.FileComplexityNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "File Complexity:";
            // 
            // FileTb
            // 
            this.FileTb.Location = new System.Drawing.Point(110, 122);
            this.FileTb.Name = "FileTb";
            this.FileTb.Size = new System.Drawing.Size(100, 20);
            this.FileTb.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "# of Files:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 16;
            // 
            // FpTotalLbl
            // 
            this.FpTotalLbl.AutoSize = true;
            this.FpTotalLbl.Location = new System.Drawing.Point(360, 436);
            this.FpTotalLbl.Name = "FpTotalLbl";
            this.FpTotalLbl.Size = new System.Drawing.Size(105, 13);
            this.FpTotalLbl.TabIndex = 17;
            this.FpTotalLbl.Text = "# of Function Points:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(345, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "External API Complexity:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "# of External APIs:";
            // 
            // LanguageLbl
            // 
            this.LanguageLbl.AutoSize = true;
            this.LanguageLbl.Location = new System.Drawing.Point(10, 194);
            this.LanguageLbl.Name = "LanguageLbl";
            this.LanguageLbl.Size = new System.Drawing.Size(86, 13);
            this.LanguageLbl.TabIndex = 22;
            this.LanguageLbl.Text = "Language Used:";
            // 
            // LanguageCb
            // 
            this.LanguageCb.FormattingEnabled = true;
            this.LanguageCb.Location = new System.Drawing.Point(110, 191);
            this.LanguageCb.Name = "LanguageCb";
            this.LanguageCb.Size = new System.Drawing.Size(355, 21);
            this.LanguageCb.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 536);
            this.Controls.Add(this.OutputRtb);
            this.Controls.Add(this.FinalCalculateBtn);
            this.Controls.Add(this.AdditonalQuestionClb);
            this.Controls.Add(this.SizingGb);
            this.Name = "MainForm";
            this.Text = "Blue Raincoat - Metric Modeller";
            this.SizingGb.ResumeLayout(false);
            this.SizingTc.ResumeLayout(false);
            this.FuncPointTp.ResumeLayout(false);
            this.FuncPointTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputComplexityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputComplexityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InquiryComplexityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileComplexityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SizingGb;
        private System.Windows.Forms.TabControl SizingTc;
        private System.Windows.Forms.TabPage FuncPointTp;
        private System.Windows.Forms.TabPage CodeLinesTp;
        private System.Windows.Forms.CheckedListBox AdditonalQuestionClb;
        private System.Windows.Forms.Button FinalCalculateBtn;
        private System.Windows.Forms.RichTextBox OutputRtb;
        private System.Windows.Forms.Label UserOutputsLbl;
        private System.Windows.Forms.Label UserInputsLbl;
        private System.Windows.Forms.NumericUpDown InputComplexityNud;
        private System.Windows.Forms.Label InputComplexityLbl;
        private System.Windows.Forms.TextBox UserOutputsTb;
        private System.Windows.Forms.TextBox UserInputsTb;
        private System.Windows.Forms.NumericUpDown OutputComplexityNud;
        private System.Windows.Forms.Label OutputComplexityLbl;
        private System.Windows.Forms.NumericUpDown InquiryComplexityNud;
        private System.Windows.Forms.Label InquiryComplexityLbl;
        private System.Windows.Forms.TextBox UserInquiresTb;
        private System.Windows.Forms.Label UserInquiresLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FpTotalLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown FileComplexityNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LanguageCb;
        private System.Windows.Forms.Label LanguageLbl;
    }
}

