namespace CST117_Milestone_4
{
    partial class Add_Book
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
            this.txtbxBookTitle = new System.Windows.Forms.TextBox();
            this.txtbxBookAuthor = new System.Windows.Forms.TextBox();
            this.txtbxBookPublisher = new System.Windows.Forms.TextBox();
            this.txtbxBookISBN = new System.Windows.Forms.TextBox();
            this.txtbxBookCost = new System.Windows.Forms.TextBox();
            this.txtbxBookQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxBookTitle
            // 
            this.txtbxBookTitle.Location = new System.Drawing.Point(122, 12);
            this.txtbxBookTitle.Name = "txtbxBookTitle";
            this.txtbxBookTitle.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookTitle.TabIndex = 0;
            // 
            // txtbxBookAuthor
            // 
            this.txtbxBookAuthor.Location = new System.Drawing.Point(122, 54);
            this.txtbxBookAuthor.Name = "txtbxBookAuthor";
            this.txtbxBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookAuthor.TabIndex = 1;
            // 
            // txtbxBookPublisher
            // 
            this.txtbxBookPublisher.Location = new System.Drawing.Point(122, 97);
            this.txtbxBookPublisher.Name = "txtbxBookPublisher";
            this.txtbxBookPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookPublisher.TabIndex = 2;
            // 
            // txtbxBookISBN
            // 
            this.txtbxBookISBN.Location = new System.Drawing.Point(122, 143);
            this.txtbxBookISBN.Name = "txtbxBookISBN";
            this.txtbxBookISBN.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookISBN.TabIndex = 3;
            // 
            // txtbxBookCost
            // 
            this.txtbxBookCost.Location = new System.Drawing.Point(122, 186);
            this.txtbxBookCost.Name = "txtbxBookCost";
            this.txtbxBookCost.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookCost.TabIndex = 4;
            // 
            // txtbxBookQuantity
            // 
            this.txtbxBookQuantity.Location = new System.Drawing.Point(122, 231);
            this.txtbxBookQuantity.Name = "txtbxBookQuantity";
            this.txtbxBookQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtbxBookQuantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Book ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Book Quantity:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(17, 277);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 320);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxBookQuantity);
            this.Controls.Add(this.txtbxBookCost);
            this.Controls.Add(this.txtbxBookISBN);
            this.Controls.Add(this.txtbxBookPublisher);
            this.Controls.Add(this.txtbxBookAuthor);
            this.Controls.Add(this.txtbxBookTitle);
            this.Name = "Add_Book";
            this.Text = "Add_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxBookTitle;
        private System.Windows.Forms.TextBox txtbxBookAuthor;
        private System.Windows.Forms.TextBox txtbxBookPublisher;
        private System.Windows.Forms.TextBox txtbxBookISBN;
        private System.Windows.Forms.TextBox txtbxBookCost;
        private System.Windows.Forms.TextBox txtbxBookQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
    }
}