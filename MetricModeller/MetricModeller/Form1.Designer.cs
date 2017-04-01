namespace MetricModeller
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FP_CalculateBtn = new System.Windows.Forms.Button();
            this.LOC_CalculateBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FP_CalculateBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Function Points";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LOC_CalculateBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LOC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FP_CalculateBtn
            // 
            this.FP_CalculateBtn.Location = new System.Drawing.Point(521, 273);
            this.FP_CalculateBtn.Name = "FP_CalculateBtn";
            this.FP_CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.FP_CalculateBtn.TabIndex = 0;
            this.FP_CalculateBtn.Text = "Calculate";
            this.FP_CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // LOC_CalculateBtn
            // 
            this.LOC_CalculateBtn.Location = new System.Drawing.Point(521, 273);
            this.LOC_CalculateBtn.Name = "LOC_CalculateBtn";
            this.LOC_CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.LOC_CalculateBtn.TabIndex = 1;
            this.LOC_CalculateBtn.Text = "Calculate";
            this.LOC_CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Blue Raincoat - Metric Modeller";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button FP_CalculateBtn;
        private System.Windows.Forms.Button LOC_CalculateBtn;
    }
}

