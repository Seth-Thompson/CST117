namespace CST117_Milestone_2
{
    partial class CST117BookInventoryMilestone2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CST117BookInventoryMilestone2));
            this.lstbxBooksInventory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbxBooksInventory
            // 
            this.lstbxBooksInventory.FormattingEnabled = true;
            this.lstbxBooksInventory.Location = new System.Drawing.Point(12, 12);
            this.lstbxBooksInventory.Name = "lstbxBooksInventory";
            this.lstbxBooksInventory.Size = new System.Drawing.Size(220, 160);
            this.lstbxBooksInventory.TabIndex = 0;
            // 
            // CST117BookInventoryMilestone2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 188);
            this.Controls.Add(this.lstbxBooksInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CST117BookInventoryMilestone2";
            this.Text = "Book Inventory";
            this.Load += new System.EventHandler(this.CST117BookInventoryMilestone2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxBooksInventory;
    }
}

