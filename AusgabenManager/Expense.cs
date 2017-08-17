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

        public int fCategoryID;

        public int CategoryID {
            get { return fCategoryID; }
        }

        public Expense(int pID, string pCategoryName) {
            fCategoryID = pID;
            fCategoryName = pCategoryName;
        }
    }
}
