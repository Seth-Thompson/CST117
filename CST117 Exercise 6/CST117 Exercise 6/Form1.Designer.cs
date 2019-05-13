namespace CST117_Exercise_6
{
    partial class CST117Exercise6DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CST117Exercise6DiceRoller));
            this.btnRoll = new System.Windows.Forms.Button();
            this.lstbxRollResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(12, 12);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(144, 108);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Start Rolling";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // lstbxRollResults
            // 
            this.lstbxRollResults.FormattingEnabled = true;
            this.lstbxRollResults.Location = new System.Drawing.Point(162, 12);
            this.lstbxRollResults.Name = "lstbxRollResults";
            this.lstbxRollResults.Size = new System.Drawing.Size(144, 108);
            this.lstbxRollResults.TabIndex = 1;
            // 
            // CST117Exercise6DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 134);
            this.Controls.Add(this.lstbxRollResults);
            this.Controls.Add(this.btnRoll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CST117Exercise6DiceRoller";
            this.Text = "CST117-Exercise 6: Dice Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox lstbxRollResults;
    }
}

