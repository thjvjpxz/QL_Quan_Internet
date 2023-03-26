using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucThe;

namespace DieuKhien
{
    public class CCheckMay
    {
        ECheckMay check;
        
        public CCheckMay(){
            check = new ECheckMay();
        }

        public bool checkMay(string IDMay)
        {
            return check.checkMay(IDMay);
        }
    }
}
