namespace CST117_Exercise_5
{
    partial class CST117Exercise5ApproximatePi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CST117Exercise5ApproximatePi));
            this.lblNumberOfTerms = new System.Windows.Forms.Label();
            this.txtbxTerms = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInputReflection = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberOfTerms
            // 
            this.lblNumberOfTerms.AutoSize = true;
            this.lblNumberOfTerms.Location = new System.Drawing.Point(26, 30);
            this.lblNumberOfTerms.Name = "lblNumberOfTerms";
            this.lblNumberOfTerms.Size = new System.Drawing.Size(89, 13);
            this.lblNumberOfTerms.TabIndex = 0;
            this.lblNumberOfTerms.Text = "Enter # of Terms:";
            // 
            // txtbxTerms
            // 
            this.txtbxTerms.Location = new System.Drawing.Point(144, 27);
            this.txtbxTerms.Name = "txtbxTerms";
            this.txtbxTerms.Size = new System.Drawing.Size(100, 20);
            this.txtbxTerms.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblInputReflection
            // 
            this.lblInputReflection.AutoSize = true;
            this.lblInputReflection.Location = new System.Drawing.Point(26, 136);
            this.lblInputReflection.Name = "lblInputReflection";
            this.lblInputReflection.Size = new System.Drawing.Size(0, 13);
            this.lblInputReflection.TabIndex = 3;
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Location = new System.Drawing.Point(26, 182);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(0, 13);
            this.lblCalculation.TabIndex = 4;
            // 
            // CST117Exercise5ApproximatePi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 226);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.lblInputReflection);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbxTerms);
            this.Controls.Add(this.lblNumberOfTerms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CST117Exercise5ApproximatePi";
            this.Text = "Approximate Pi";
            this.Load += new System.EventHandler(this.CST117Exercise5ApproximatePi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfTerms;
        private System.Windows.Forms.TextBox txtbxTerms;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInputReflection;
        private System.Windows.Forms.Label lblCalculation;
    }
}

