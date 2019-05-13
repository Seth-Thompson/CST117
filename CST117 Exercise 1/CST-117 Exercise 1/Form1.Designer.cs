namespace CST_117_Exercise_1
{
    partial class Exercise1
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDisplayName = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.btnClearName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(180, 43);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(267, 20);
            this.txtBxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // btnDisplayName
            // 
            this.btnDisplayName.Location = new System.Drawing.Point(129, 93);
            this.btnDisplayName.Name = "btnDisplayName";
            this.btnDisplayName.Size = new System.Drawing.Size(104, 23);
            this.btnDisplayName.TabIndex = 1;
            this.btnDisplayName.Text = "Display Name";
            this.btnDisplayName.UseVisualStyleBackColor = true;
            this.btnDisplayName.Click += new System.EventHandler(this.BtnDisplayName_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(282, 98);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayName.TabIndex = 3;
            // 
            // btnClearName
            // 
            this.btnClearName.Location = new System.Drawing.Point(129, 131);
            this.btnClearName.Name = "btnClearName";
            this.btnClearName.Size = new System.Drawing.Size(104, 23);
            this.btnClearName.TabIndex = 2;
            this.btnClearName.Text = "Clear Name";
            this.btnClearName.UseVisualStyleBackColor = true;
            this.btnClearName.Click += new System.EventHandler(this.BtnClearName_Click);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 175);
            this.Controls.Add(this.btnClearName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.btnDisplayName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBxName);
            this.Name = "Exercise1";
            this.Text = "Exercise 1";
            this.Load += new System.EventHandler(this.Exercise1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Button btnClearName;
    }
}

