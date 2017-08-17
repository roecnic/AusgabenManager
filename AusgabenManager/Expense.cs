using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusgabenManager {
    class Expense {
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

        public Expense(int pID, string pCategoryName) {
            fCategoryID = pID;
            fCategoryName = pCategoryName;
        }
    }
}
