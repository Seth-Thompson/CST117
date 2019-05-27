namespace CST117_Programming_Project_5
{
    partial class LuckyNumberForm
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
            this.lblLuckyNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLuckyNumber
            // 
            this.lblLuckyNumber.AutoSize = true;
            this.lblLuckyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(209)))), ((int)(((byte)(69)))));
            this.lblLuckyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuckyNumber.Location = new System.Drawing.Point(115, 222);
            this.lblLuckyNumber.Name = "lblLuckyNumber";
            this.lblLuckyNumber.Size = new System.Drawing.Size(207, 36);
            this.lblLuckyNumber.TabIndex = 0;
            this.lblLuckyNumber.Text = "Lucky Number";
            // 
            // LuckyNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST117_Programming_Project_5.Properties.Resources.Lucky_Number;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.lblLuckyNumber);
            this.Name = "LuckyNumberForm";
            this.Text = "Your Results!";
            this.Load += new System.EventHandler(this.LuckyNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLuckyNumber;
    }
}