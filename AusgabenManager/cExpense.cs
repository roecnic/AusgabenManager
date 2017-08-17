using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusgabenManager {
    class cExpense {
        private string fCategoryName;

        public string CategoryName {
            get { return fCategoryName; }
            set { fCategoryName = value; }
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

        public cExpense(int pID, string pCategoryName, double pAmount) {
            fCategoryID = pID;
            fCategoryName = pCategoryName;
        }
    }
}
