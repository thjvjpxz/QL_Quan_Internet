using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace Controller
{
    public class CFindMay
    {
        EFindMay findmay;

        public CFindMay()
        {
            findmay = new EFindMay();
        }

        public DataTable FindMay(string ID)
        {
            return findmay.FindMay(ID);
        }
    }
}
