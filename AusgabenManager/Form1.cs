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
        }

        private void btnCreateNewExpense_Click (object sender, EventArgs e) {
            try {
                if (tbxAmount.Text != "" && tbxExpense.Text != "" && cbxCategory.SelectedIndex > 0) {
                    expenseList.Add(new cExpense(expenseList.Count, Convert.ToString(categoryList.ElementAt(cbxCategory.SelectedIndex)), Convert.ToDouble(tbxAmount.Text)));
                }
            } catch (Exception ex) {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}
