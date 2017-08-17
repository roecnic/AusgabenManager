using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusgabenManager {
    class cCategory {
        private string fName;

        public string CategoryName {
            get { return fName; }
            set { fName = value; }
        }

        private int fID;

        public int ID {
            get { return fID; }
        }

        public cCategory(int pID, string pCategoryName) {
            fID = pID;
            fName = pCategoryName;
        }
    }
}
