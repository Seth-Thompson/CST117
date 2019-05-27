namespace CST117_Programming_Project_5
{
    partial class CST117ProgrammingProject5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxYear = new System.Windows.Forms.ComboBox();
            this.cmbbxMonth = new System.Windows.Forms.ComboBox();
            this.cmbbxDay = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtbxFavoriteColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your birth month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your birth day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your favorite color:";
            // 
            // cmbbxYear
            // 
            this.cmbbxYear.FormattingEnabled = true;
            this.cmbbxYear.Location = new System.Drawing.Point(163, 23);
            this.cmbbxYear.Name = "cmbbxYear";
            this.cmbbxYear.Size = new System.Drawing.Size(121, 21);
            this.cmbbxYear.TabIndex = 4;
            this.cmbbxYear.Text = "2019";
            this.cmbbxYear.SelectedIndexChanged += new System.EventHandler(this.CmbbxYear_SelectedIndexChanged);
            // 
            // cmbbxMonth
            // 
            this.cmbbxMonth.FormattingEnabled = true;
            this.cmbbxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbbxMonth.Location = new System.Drawing.Point(163, 67);
            this.cmbbxMonth.Name = "cmbbxMonth";
            this.cmbbxMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbbxMonth.TabIndex = 5;
            this.cmbbxMonth.Text = "January";
            this.cmbbxMonth.SelectedIndexChanged += new System.EventHandler(this.CmbbxMonth_SelectedIndexChanged);
            // 
            // cmbbxDay
            // 
            this.cmbbxDay.FormattingEnabled = true;
            this.cmbbxDay.Location = new System.Drawing.Point(163, 110);
            this.cmbbxDay.Name = "cmbbxDay";
            this.cmbbxDay.Size = new System.Drawing.Size(121, 21);
            this.cmbbxDay.TabIndex = 6;
            this.cmbbxDay.Text = "1";
            this.cmbbxDay.SelectedIndexChanged += new System.EventHandler(this.CmbbxDay_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(259, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtbxFavoriteColor
            // 
            this.txtbxFavoriteColor.Location = new System.Drawing.Point(163, 154);
            this.txtbxFavoriteColor.Name = "txtbxFavoriteColor";
            this.txtbxFavoriteColor.Size = new System.Drawing.Size(121, 20);
            this.txtbxFavoriteColor.TabIndex = 9;
            // 
            // CST117ProgrammingProject5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 254);
            this.Controls.Add(this.txtbxFavoriteColor);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbbxDay);
            this.Controls.Add(this.cmbbxMonth);
            this.Controls.Add(this.cmbbxYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CST117ProgrammingProject5";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.CST117ProgrammingProject5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxYear;
        private System.Windows.Forms.ComboBox cmbbxMonth;
        private System.Windows.Forms.ComboBox cmbbxDay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtbxFavoriteColor;
    }
}

