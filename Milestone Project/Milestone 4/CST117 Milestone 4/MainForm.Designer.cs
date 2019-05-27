namespace CST117_Milestone_4
{
    partial class MainForm
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
            this.lstbxBookInventory = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpbxSearchItem = new System.Windows.Forms.GroupBox();
            this.txtbxLookingFor = new System.Windows.Forms.TextBox();
            this.grpbxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.cmbbxCriteria = new System.Windows.Forms.ComboBox();
            this.grpbxSearchItem.SuspendLayout();
            this.grpbxSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxBookInventory
            // 
            this.lstbxBookInventory.FormattingEnabled = true;
            this.lstbxBookInventory.Location = new System.Drawing.Point(12, 12);
            this.lstbxBookInventory.Name = "lstbxBookInventory";
            this.lstbxBookInventory.Size = new System.Drawing.Size(260, 173);
            this.lstbxBookInventory.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(291, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(291, 113);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.Location = new System.Drawing.Point(291, 155);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(75, 23);
            this.btnRestock.TabIndex = 4;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.BtnRestock_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(394, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // grpbxSearchItem
            // 
            this.grpbxSearchItem.Controls.Add(this.txtbxLookingFor);
            this.grpbxSearchItem.Location = new System.Drawing.Point(388, 81);
            this.grpbxSearchItem.Name = "grpbxSearchItem";
            this.grpbxSearchItem.Size = new System.Drawing.Size(191, 55);
            this.grpbxSearchItem.TabIndex = 7;
            this.grpbxSearchItem.TabStop = false;
            this.grpbxSearchItem.Text = "Item:";
            // 
            // txtbxLookingFor
            // 
            this.txtbxLookingFor.Location = new System.Drawing.Point(7, 20);
            this.txtbxLookingFor.Name = "txtbxLookingFor";
            this.txtbxLookingFor.Size = new System.Drawing.Size(175, 20);
            this.txtbxLookingFor.TabIndex = 0;
            // 
            // grpbxSearchCriteria
            // 
            this.grpbxSearchCriteria.Controls.Add(this.cmbbxCriteria);
            this.grpbxSearchCriteria.Location = new System.Drawing.Point(388, 12);
            this.grpbxSearchCriteria.Name = "grpbxSearchCriteria";
            this.grpbxSearchCriteria.Size = new System.Drawing.Size(191, 55);
            this.grpbxSearchCriteria.TabIndex = 6;
            this.grpbxSearchCriteria.TabStop = false;
            this.grpbxSearchCriteria.Text = "Search Criteria:";
            // 
            // cmbbxCriteria
            // 
            this.cmbbxCriteria.FormattingEnabled = true;
            this.cmbbxCriteria.Items.AddRange(new object[] {
            "Book Title",
            "Quantity",
            "Author",
            "ISBN",
            "Publisher",
            "Item ID",
            "Price"});
            this.cmbbxCriteria.Location = new System.Drawing.Point(6, 19);
            this.cmbbxCriteria.Name = "cmbbxCriteria";
            this.cmbbxCriteria.Size = new System.Drawing.Size(176, 21);
            this.cmbbxCriteria.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 202);
            this.Controls.Add(this.grpbxSearchItem);
            this.Controls.Add(this.grpbxSearchCriteria);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxBookInventory);
            this.Name = "MainForm";
            this.Text = "CST117 Milestone";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpbxSearchItem.ResumeLayout(false);
            this.grpbxSearchItem.PerformLayout();
            this.grpbxSearchCriteria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxBookInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpbxSearchItem;
        private System.Windows.Forms.TextBox txtbxLookingFor;
        private System.Windows.Forms.GroupBox grpbxSearchCriteria;
        private System.Windows.Forms.ComboBox cmbbxCriteria;
    }
}

