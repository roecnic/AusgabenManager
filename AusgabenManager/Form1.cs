using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AusgabenManager {
    public partial class Form1 : Form {
        private List<cExpense> expenseList = new List<cExpense>();
        private List<cCategory> categoryList = new List<cCategory>();

        public Form1 () {
            InitializeComponent();

            categoryList.Add(new cCategory(0, "Auto"));
            SortCategoryList();
        }

        private void btnCreateNewExpense_Click (object sender, EventArgs e) {
            try {
                if (tbxAmount.Text != "" && tbxExpense.Text != "" && cbxCategory.SelectedIndex >= 0) {
                    expenseList.Add(new cExpense(expenseList.Count, tbxExpense.Text, cbxCategory.SelectedIndex, Convert.ToDouble(tbxAmount.Text)));
                    SortExpenseList();
                } else if (cbxCategory.SelectedIndex < 0)
                    throw new Exception("Invalid category");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SortExpenseList () {
            expenseList.Sort((x, y) => x.CategoryID.CompareTo(y.CategoryID));
            lbxExpenses.Items.Clear();
            foreach(var currentItem in expenseList) {
                lbxExpenses.Items.Add(currentItem.ExpenseDesc + " - " + currentItem.Amount + " - " + currentItem.ID + " - " + currentItem.CategoryID);
            }
        }

        private void SortCategoryList () {
            categoryList.Sort((x, y) => x.ID.CompareTo(y.ID));
            lbxCategories.Items.Clear();
            lbxCategories.Items.Add("All Categories");

            foreach(var currentItem in categoryList) {
                lbxCategories.Items.Add(currentItem.CategoryName);
                cbxCategory.Items.Add(currentItem.CategoryName);
            }
        }
    }
}
