namespace CST117_Exercise_8
{
    partial class CST117Exercise8CalorieCalculator
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
            this.txtbxFats = new System.Windows.Forms.TextBox();
            this.lblFats = new System.Windows.Forms.Label();
            this.txtbxCarbohydrates = new System.Windows.Forms.TextBox();
            this.lblCarbohydrates = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCaloriesFromFats = new System.Windows.Forms.Label();
            this.lblCaloriesFromCarbohydrates = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxFats
            // 
            this.txtbxFats.Location = new System.Drawing.Point(120, 20);
            this.txtbxFats.Name = "txtbxFats";
            this.txtbxFats.Size = new System.Drawing.Size(100, 20);
            this.txtbxFats.TabIndex = 0;
            // 
            // lblFats
            // 
            this.lblFats.AutoSize = true;
            this.lblFats.Location = new System.Drawing.Point(21, 23);
            this.lblFats.Name = "lblFats";
            this.lblFats.Size = new System.Drawing.Size(30, 13);
            this.lblFats.TabIndex = 1;
            this.lblFats.Text = "Fats:";
            // 
            // txtbxCarbohydrates
            // 
            this.txtbxCarbohydrates.Location = new System.Drawing.Point(120, 64);
            this.txtbxCarbohydrates.Name = "txtbxCarbohydrates";
            this.txtbxCarbohydrates.Size = new System.Drawing.Size(100, 20);
            this.txtbxCarbohydrates.TabIndex = 2;
            // 
            // lblCarbohydrates
            // 
            this.lblCarbohydrates.AutoSize = true;
            this.lblCarbohydrates.Location = new System.Drawing.Point(21, 67);
            this.lblCarbohydrates.Name = "lblCarbohydrates";
            this.lblCarbohydrates.Size = new System.Drawing.Size(78, 13);
            this.lblCarbohydrates.TabIndex = 3;
            this.lblCarbohydrates.Text = "Carbohydrates:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 109);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblCaloriesFromFats
            // 
            this.lblCaloriesFromFats.AutoSize = true;
            this.lblCaloriesFromFats.Location = new System.Drawing.Point(249, 23);
            this.lblCaloriesFromFats.Name = "lblCaloriesFromFats";
            this.lblCaloriesFromFats.Size = new System.Drawing.Size(0, 13);
            this.lblCaloriesFromFats.TabIndex = 5;
            // 
            // lblCaloriesFromCarbohydrates
            // 
            this.lblCaloriesFromCarbohydrates.AutoSize = true;
            this.lblCaloriesFromCarbohydrates.Location = new System.Drawing.Point(249, 67);
            this.lblCaloriesFromCarbohydrates.Name = "lblCaloriesFromCarbohydrates";
            this.lblCaloriesFromCarbohydrates.Size = new System.Drawing.Size(0, 13);
            this.lblCaloriesFromCarbohydrates.TabIndex = 6;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(249, 114);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCalories.TabIndex = 7;
            // 
            // CST117Exercise8CalorieCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 153);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblCaloriesFromCarbohydrates);
            this.Controls.Add(this.lblCaloriesFromFats);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCarbohydrates);
            this.Controls.Add(this.txtbxCarbohydrates);
            this.Controls.Add(this.lblFats);
            this.Controls.Add(this.txtbxFats);
            this.Name = "CST117Exercise8CalorieCalculator";
            this.Text = "CST117 - Exercise 8: Calorie Calculator";
            this.Load += new System.EventHandler(this.CST117Exercise8CalorieCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFats;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.TextBox txtbxCarbohydrates;
        private System.Windows.Forms.Label lblCarbohydrates;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCaloriesFromFats;
        private System.Windows.Forms.Label lblCaloriesFromCarbohydrates;
        private System.Windows.Forms.Label lblTotalCalories;
    }
}

