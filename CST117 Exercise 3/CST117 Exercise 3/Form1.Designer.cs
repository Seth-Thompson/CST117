namespace CST117_Exercise_3
{
    partial class CST117Exercise3
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
            this.txtbxEarthWeight = new System.Windows.Forms.TextBox();
            this.txtbxMarsWeight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblEnterEarthWeight = new System.Windows.Forms.Label();
            this.lblWeightMars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxEarthWeight
            // 
            this.txtbxEarthWeight.Location = new System.Drawing.Point(176, 29);
            this.txtbxEarthWeight.Name = "txtbxEarthWeight";
            this.txtbxEarthWeight.Size = new System.Drawing.Size(100, 20);
            this.txtbxEarthWeight.TabIndex = 0;
            // 
            // txtbxMarsWeight
            // 
            this.txtbxMarsWeight.Location = new System.Drawing.Point(176, 79);
            this.txtbxMarsWeight.Name = "txtbxMarsWeight";
            this.txtbxMarsWeight.Size = new System.Drawing.Size(100, 20);
            this.txtbxMarsWeight.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(176, 124);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // lblEnterEarthWeight
            // 
            this.lblEnterEarthWeight.AutoSize = true;
            this.lblEnterEarthWeight.Location = new System.Drawing.Point(35, 32);
            this.lblEnterEarthWeight.Name = "lblEnterEarthWeight";
            this.lblEnterEarthWeight.Size = new System.Drawing.Size(135, 13);
            this.lblEnterEarthWeight.TabIndex = 3;
            this.lblEnterEarthWeight.Text = "Enter your weight on Earth:";
            // 
            // lblWeightMars
            // 
            this.lblWeightMars.AutoSize = true;
            this.lblWeightMars.Location = new System.Drawing.Point(38, 82);
            this.lblWeightMars.Name = "lblWeightMars";
            this.lblWeightMars.Size = new System.Drawing.Size(107, 13);
            this.lblWeightMars.TabIndex = 4;
            this.lblWeightMars.Text = "Your weight on Mars:";
            // 
            // CST117Exercise3
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 166);
            this.Controls.Add(this.lblWeightMars);
            this.Controls.Add(this.lblEnterEarthWeight);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtbxMarsWeight);
            this.Controls.Add(this.txtbxEarthWeight);
            this.Name = "CST117Exercise3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Your Weight on Mars";
            this.Load += new System.EventHandler(this.CST117Exercise3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxEarthWeight;
        private System.Windows.Forms.TextBox txtbxMarsWeight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblEnterEarthWeight;
        private System.Windows.Forms.Label lblWeightMars;
    }
}

