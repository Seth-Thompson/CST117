namespace CST117_Programming_Project_3
{
    partial class CST117ProgrammingProject3
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblLowerCase = new System.Windows.Forms.Label();
            this.lblAlphabetically = new System.Windows.Forms.Label();
            this.lblLongestWord = new System.Windows.Forms.Label();
            this.lblMostVowels = new System.Windows.Forms.Label();
            this.lblConfirmText = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // lblLowerCase
            // 
            this.lblLowerCase.AutoSize = true;
            this.lblLowerCase.Location = new System.Drawing.Point(23, 64);
            this.lblLowerCase.Name = "lblLowerCase";
            this.lblLowerCase.Size = new System.Drawing.Size(35, 13);
            this.lblLowerCase.TabIndex = 0;
            this.lblLowerCase.Text = "label1";
            // 
            // lblAlphabetically
            // 
            this.lblAlphabetically.AutoSize = true;
            this.lblAlphabetically.Location = new System.Drawing.Point(23, 112);
            this.lblAlphabetically.Name = "lblAlphabetically";
            this.lblAlphabetically.Size = new System.Drawing.Size(35, 13);
            this.lblAlphabetically.TabIndex = 1;
            this.lblAlphabetically.Text = "label2";
            // 
            // lblLongestWord
            // 
            this.lblLongestWord.AutoSize = true;
            this.lblLongestWord.Location = new System.Drawing.Point(23, 156);
            this.lblLongestWord.Name = "lblLongestWord";
            this.lblLongestWord.Size = new System.Drawing.Size(35, 13);
            this.lblLongestWord.TabIndex = 2;
            this.lblLongestWord.Text = "label3";
            // 
            // lblMostVowels
            // 
            this.lblMostVowels.AutoSize = true;
            this.lblMostVowels.Location = new System.Drawing.Point(23, 202);
            this.lblMostVowels.Name = "lblMostVowels";
            this.lblMostVowels.Size = new System.Drawing.Size(35, 13);
            this.lblMostVowels.TabIndex = 3;
            this.lblMostVowels.Text = "label4";
            // 
            // lblConfirmText
            // 
            this.lblConfirmText.AutoSize = true;
            this.lblConfirmText.Location = new System.Drawing.Point(23, 250);
            this.lblConfirmText.Name = "lblConfirmText";
            this.lblConfirmText.Size = new System.Drawing.Size(35, 13);
            this.lblConfirmText.TabIndex = 4;
            this.lblConfirmText.Text = "label5";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(26, 22);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 5;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // CST117ProgrammingProject3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 320);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblConfirmText);
            this.Controls.Add(this.lblMostVowels);
            this.Controls.Add(this.lblLongestWord);
            this.Controls.Add(this.lblAlphabetically);
            this.Controls.Add(this.lblLowerCase);
            this.Name = "CST117ProgrammingProject3";
            this.Text = "Programming Project 3";
            this.Load += new System.EventHandler(this.CST117ProgrammingProject3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label lblLowerCase;
        private System.Windows.Forms.Label lblAlphabetically;
        private System.Windows.Forms.Label lblLongestWord;
        private System.Windows.Forms.Label lblMostVowels;
        private System.Windows.Forms.Label lblConfirmText;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

