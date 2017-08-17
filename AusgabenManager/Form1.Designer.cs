namespace AusgabenManager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxExpense = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxNewExpense = new System.Windows.Forms.GroupBox();
            this.btnCreateNewExpense = new System.Windows.Forms.Button();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.lbxExpenses = new System.Windows.Forms.ListBox();
            this.gbxNewExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(14, 31);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(52, 13);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Ausgabe:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(14, 57);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(41, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Betrag:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 84);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategorie:";
            // 
            // tbxExpense
            // 
            this.tbxExpense.Location = new System.Drawing.Point(75, 28);
            this.tbxExpense.Name = "tbxExpense";
            this.tbxExpense.Size = new System.Drawing.Size(185, 20);
            this.tbxExpense.TabIndex = 3;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(75, 54);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(185, 20);
            this.tbxAmount.TabIndex = 4;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(75, 81);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(185, 21);
            this.cbxCategory.TabIndex = 5;
            // 
            // gbxNewExpense
            // 
            this.gbxNewExpense.Controls.Add(this.btnCreateNewExpense);
            this.gbxNewExpense.Controls.Add(this.tbxExpense);
            this.gbxNewExpense.Controls.Add(this.cbxCategory);
            this.gbxNewExpense.Controls.Add(this.lblExpenseName);
            this.gbxNewExpense.Controls.Add(this.tbxAmount);
            this.gbxNewExpense.Controls.Add(this.lblAmount);
            this.gbxNewExpense.Controls.Add(this.lblCategory);
            this.gbxNewExpense.Location = new System.Drawing.Point(13, 13);
            this.gbxNewExpense.Name = "gbxNewExpense";
            this.gbxNewExpense.Size = new System.Drawing.Size(279, 147);
            this.gbxNewExpense.TabIndex = 6;
            this.gbxNewExpense.TabStop = false;
            this.gbxNewExpense.Text = "Neue Ausgabe";
            // 
            // btnCreateNewExpense
            // 
            this.btnCreateNewExpense.Location = new System.Drawing.Point(17, 108);
            this.btnCreateNewExpense.Name = "btnCreateNewExpense";
            this.btnCreateNewExpense.Size = new System.Drawing.Size(243, 23);
            this.btnCreateNewExpense.TabIndex = 6;
            this.btnCreateNewExpense.Text = "Ausgabe hinzufügen";
            this.btnCreateNewExpense.UseVisualStyleBackColor = true;
            this.btnCreateNewExpense.Click += new System.EventHandler(this.btnCreateNewExpense_Click);
            // 
            // lbxCategories
            // 
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.Location = new System.Drawing.Point(13, 182);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(120, 173);
            this.lbxCategories.TabIndex = 7;
            // 
            // lbxExpenses
            // 
            this.lbxExpenses.FormattingEnabled = true;
            this.lbxExpenses.Location = new System.Drawing.Point(172, 182);
            this.lbxExpenses.Name = "lbxExpenses";
            this.lbxExpenses.Size = new System.Drawing.Size(120, 173);
            this.lbxExpenses.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 375);
            this.Controls.Add(this.lbxExpenses);
            this.Controls.Add(this.lbxCategories);
            this.Controls.Add(this.gbxNewExpense);
            this.Name = "Form1";
            this.Text = "Ausgaben Manager";
            this.gbxNewExpense.ResumeLayout(false);
            this.gbxNewExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbxExpense;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxNewExpense;
        private System.Windows.Forms.Button btnCreateNewExpense;
        private System.Windows.Forms.ListBox lbxCategories;
        private System.Windows.Forms.ListBox lbxExpenses;
    }
}

