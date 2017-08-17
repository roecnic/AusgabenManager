using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusgabenManager {
    class cExpense {
        private int fID;

        public int ID {
            get { return fID; }
        }

        private string fExpenseDesc;

        public string ExpenseDesc {
            get { return fExpenseDesc; }
            set { fExpenseDesc = value; }
        }

        private int fCategoryID;

        public int CategoryID {
            get { return fCategoryID; }
        }

        private double fAmount;

        public double Amount {
            get { return fAmount; }
            set { fAmount = value; }
        }

        public cExpense(int pID, string pExpenseDesc, int pCategoryID, double pAmount) {
            fID = pID;
            fExpenseDesc = pExpenseDesc;
            fCategoryID = pCategoryID;
            fAmount = pAmount;
        }
    }
}
