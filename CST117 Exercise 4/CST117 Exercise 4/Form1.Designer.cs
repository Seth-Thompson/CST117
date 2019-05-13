namespace CST117_Exercise_4
{
    partial class CST117Exercise4
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
            this.txtbxSeconds = new System.Windows.Forms.TextBox();
            this.lblTypeSeconds = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxSeconds
            // 
            this.txtbxSeconds.Location = new System.Drawing.Point(189, 43);
            this.txtbxSeconds.Name = "txtbxSeconds";
            this.txtbxSeconds.Size = new System.Drawing.Size(100, 20);
            this.txtbxSeconds.TabIndex = 0;
            // 
            // lblTypeSeconds
            // 
            this.lblTypeSeconds.AutoSize = true;
            this.lblTypeSeconds.Location = new System.Drawing.Point(37, 46);
            this.lblTypeSeconds.Name = "lblTypeSeconds";
            this.lblTypeSeconds.Size = new System.Drawing.Size(146, 13);
            this.lblTypeSeconds.TabIndex = 1;
            this.lblTypeSeconds.Text = "Enter the number of seconds:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(37, 146);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // CST117Exercise4
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 193);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTypeSeconds);
            this.Controls.Add(this.txtbxSeconds);
            this.Name = "CST117Exercise4";
            this.Text = "CST 117 Exercise 4: Seconds Elapsed";
            this.Load += new System.EventHandler(this.CST117Exercise4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSeconds;
        private System.Windows.Forms.Label lblTypeSeconds;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
    }
}

