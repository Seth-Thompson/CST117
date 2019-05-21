namespace CST117_Programming_Exercise_2
{
    partial class CST117ProgramingExercise2
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
            this.grpbxSize = new System.Windows.Forms.GroupBox();
            this.radiobtnSmall = new System.Windows.Forms.RadioButton();
            this.radiobtnMedium = new System.Windows.Forms.RadioButton();
            this.radiobtnLarge = new System.Windows.Forms.RadioButton();
            this.radiobtnExtLarge = new System.Windows.Forms.RadioButton();
            this.grpbxPizza = new System.Windows.Forms.GroupBox();
            this.lstbxPizzas = new System.Windows.Forms.ListBox();
            this.grpbxSpecialInstructions = new System.Windows.Forms.GroupBox();
            this.chxbxDoubleSauce = new System.Windows.Forms.CheckBox();
            this.chxbxDoubleCheese = new System.Windows.Forms.CheckBox();
            this.chxbxGlutenFree = new System.Windows.Forms.CheckBox();
            this.chxbxToGo = new System.Windows.Forms.CheckBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnMakePizza = new System.Windows.Forms.Button();
            this.grpbxSize.SuspendLayout();
            this.grpbxPizza.SuspendLayout();
            this.grpbxSpecialInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSize
            // 
            this.grpbxSize.Controls.Add(this.radiobtnExtLarge);
            this.grpbxSize.Controls.Add(this.radiobtnLarge);
            this.grpbxSize.Controls.Add(this.radiobtnMedium);
            this.grpbxSize.Controls.Add(this.radiobtnSmall);
            this.grpbxSize.Location = new System.Drawing.Point(276, 45);
            this.grpbxSize.Name = "grpbxSize";
            this.grpbxSize.Size = new System.Drawing.Size(200, 122);
            this.grpbxSize.TabIndex = 1;
            this.grpbxSize.TabStop = false;
            this.grpbxSize.Text = "Sizes:";
            // 
            // radiobtnSmall
            // 
            this.radiobtnSmall.AutoSize = true;
            this.radiobtnSmall.Location = new System.Drawing.Point(7, 20);
            this.radiobtnSmall.Name = "radiobtnSmall";
            this.radiobtnSmall.Size = new System.Drawing.Size(50, 17);
            this.radiobtnSmall.TabIndex = 0;
            this.radiobtnSmall.TabStop = true;
            this.radiobtnSmall.Text = "Small";
            this.radiobtnSmall.UseVisualStyleBackColor = true;
            this.radiobtnSmall.CheckedChanged += new System.EventHandler(this.RadiobtnSmall_CheckedChanged);
            // 
            // radiobtnMedium
            // 
            this.radiobtnMedium.AutoSize = true;
            this.radiobtnMedium.Location = new System.Drawing.Point(7, 44);
            this.radiobtnMedium.Name = "radiobtnMedium";
            this.radiobtnMedium.Size = new System.Drawing.Size(62, 17);
            this.radiobtnMedium.TabIndex = 1;
            this.radiobtnMedium.TabStop = true;
            this.radiobtnMedium.Text = "Medium";
            this.radiobtnMedium.UseVisualStyleBackColor = true;
            this.radiobtnMedium.CheckedChanged += new System.EventHandler(this.RadiobtnMedium_CheckedChanged);
            // 
            // radiobtnLarge
            // 
            this.radiobtnLarge.AutoSize = true;
            this.radiobtnLarge.Location = new System.Drawing.Point(7, 68);
            this.radiobtnLarge.Name = "radiobtnLarge";
            this.radiobtnLarge.Size = new System.Drawing.Size(52, 17);
            this.radiobtnLarge.TabIndex = 2;
            this.radiobtnLarge.TabStop = true;
            this.radiobtnLarge.Text = "Large";
            this.radiobtnLarge.UseVisualStyleBackColor = true;
            this.radiobtnLarge.CheckedChanged += new System.EventHandler(this.RadiobtnLarge_CheckedChanged);
            // 
            // radiobtnExtLarge
            // 
            this.radiobtnExtLarge.AutoSize = true;
            this.radiobtnExtLarge.Location = new System.Drawing.Point(7, 92);
            this.radiobtnExtLarge.Name = "radiobtnExtLarge";
            this.radiobtnExtLarge.Size = new System.Drawing.Size(79, 17);
            this.radiobtnExtLarge.TabIndex = 3;
            this.radiobtnExtLarge.TabStop = true;
            this.radiobtnExtLarge.Text = "Extra Large";
            this.radiobtnExtLarge.UseVisualStyleBackColor = true;
            this.radiobtnExtLarge.CheckedChanged += new System.EventHandler(this.RadiobtnExtLarge_CheckedChanged);
            // 
            // grpbxPizza
            // 
            this.grpbxPizza.Controls.Add(this.lstbxPizzas);
            this.grpbxPizza.Location = new System.Drawing.Point(48, 45);
            this.grpbxPizza.Name = "grpbxPizza";
            this.grpbxPizza.Size = new System.Drawing.Size(200, 122);
            this.grpbxPizza.TabIndex = 2;
            this.grpbxPizza.TabStop = false;
            this.grpbxPizza.Text = "Pizzas:";
            // 
            // lstbxPizzas
            // 
            this.lstbxPizzas.FormattingEnabled = true;
            this.lstbxPizzas.Items.AddRange(new object[] {
            "Cheese",
            "Sausage",
            "Pepperoni",
            "Combo"});
            this.lstbxPizzas.Location = new System.Drawing.Point(7, 20);
            this.lstbxPizzas.Name = "lstbxPizzas";
            this.lstbxPizzas.Size = new System.Drawing.Size(120, 95);
            this.lstbxPizzas.TabIndex = 0;
            // 
            // grpbxSpecialInstructions
            // 
            this.grpbxSpecialInstructions.Controls.Add(this.chxbxToGo);
            this.grpbxSpecialInstructions.Controls.Add(this.chxbxGlutenFree);
            this.grpbxSpecialInstructions.Controls.Add(this.chxbxDoubleCheese);
            this.grpbxSpecialInstructions.Controls.Add(this.chxbxDoubleSauce);
            this.grpbxSpecialInstructions.Location = new System.Drawing.Point(496, 45);
            this.grpbxSpecialInstructions.Name = "grpbxSpecialInstructions";
            this.grpbxSpecialInstructions.Size = new System.Drawing.Size(200, 122);
            this.grpbxSpecialInstructions.TabIndex = 3;
            this.grpbxSpecialInstructions.TabStop = false;
            this.grpbxSpecialInstructions.Text = "Special Instructions:";
            // 
            // chxbxDoubleSauce
            // 
            this.chxbxDoubleSauce.AutoSize = true;
            this.chxbxDoubleSauce.Location = new System.Drawing.Point(7, 20);
            this.chxbxDoubleSauce.Name = "chxbxDoubleSauce";
            this.chxbxDoubleSauce.Size = new System.Drawing.Size(94, 17);
            this.chxbxDoubleSauce.TabIndex = 0;
            this.chxbxDoubleSauce.Text = "Double Sauce";
            this.chxbxDoubleSauce.UseVisualStyleBackColor = true;
            // 
            // chxbxDoubleCheese
            // 
            this.chxbxDoubleCheese.AutoSize = true;
            this.chxbxDoubleCheese.Location = new System.Drawing.Point(7, 44);
            this.chxbxDoubleCheese.Name = "chxbxDoubleCheese";
            this.chxbxDoubleCheese.Size = new System.Drawing.Size(99, 17);
            this.chxbxDoubleCheese.TabIndex = 1;
            this.chxbxDoubleCheese.Text = "Double Cheese";
            this.chxbxDoubleCheese.UseVisualStyleBackColor = true;
            // 
            // chxbxGlutenFree
            // 
            this.chxbxGlutenFree.AutoSize = true;
            this.chxbxGlutenFree.Location = new System.Drawing.Point(7, 68);
            this.chxbxGlutenFree.Name = "chxbxGlutenFree";
            this.chxbxGlutenFree.Size = new System.Drawing.Size(81, 17);
            this.chxbxGlutenFree.TabIndex = 2;
            this.chxbxGlutenFree.Text = "Gluten Free";
            this.chxbxGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chxbxToGo
            // 
            this.chxbxToGo.AutoSize = true;
            this.chxbxToGo.Location = new System.Drawing.Point(7, 92);
            this.chxbxToGo.Name = "chxbxToGo";
            this.chxbxToGo.Size = new System.Drawing.Size(56, 17);
            this.chxbxToGo.TabIndex = 3;
            this.chxbxToGo.Text = "To Go";
            this.chxbxToGo.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(45, 204);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 4;
            // 
            // btnMakePizza
            // 
            this.btnMakePizza.Location = new System.Drawing.Point(276, 256);
            this.btnMakePizza.Name = "btnMakePizza";
            this.btnMakePizza.Size = new System.Drawing.Size(75, 23);
            this.btnMakePizza.TabIndex = 5;
            this.btnMakePizza.Text = "Make Pizza";
            this.btnMakePizza.UseVisualStyleBackColor = true;
            this.btnMakePizza.Click += new System.EventHandler(this.BtnMakePizza_Click);
            // 
            // CST117ProgramingExercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 318);
            this.Controls.Add(this.btnMakePizza);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.grpbxSpecialInstructions);
            this.Controls.Add(this.grpbxPizza);
            this.Controls.Add(this.grpbxSize);
            this.Name = "CST117ProgramingExercise2";
            this.Text = "Pizza Maker";
            this.Load += new System.EventHandler(this.CST117ProgramingExercise2_Load);
            this.grpbxSize.ResumeLayout(false);
            this.grpbxSize.PerformLayout();
            this.grpbxPizza.ResumeLayout(false);
            this.grpbxSpecialInstructions.ResumeLayout(false);
            this.grpbxSpecialInstructions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSize;
        private System.Windows.Forms.RadioButton radiobtnExtLarge;
        private System.Windows.Forms.RadioButton radiobtnLarge;
        private System.Windows.Forms.RadioButton radiobtnMedium;
        private System.Windows.Forms.RadioButton radiobtnSmall;
        private System.Windows.Forms.GroupBox grpbxPizza;
        private System.Windows.Forms.ListBox lstbxPizzas;
        private System.Windows.Forms.GroupBox grpbxSpecialInstructions;
        private System.Windows.Forms.CheckBox chxbxToGo;
        private System.Windows.Forms.CheckBox chxbxGlutenFree;
        private System.Windows.Forms.CheckBox chxbxDoubleCheese;
        private System.Windows.Forms.CheckBox chxbxDoubleSauce;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnMakePizza;
    }
}

