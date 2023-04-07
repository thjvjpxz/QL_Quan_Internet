using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Controller
{
    public class CFindSP
    {
        EFindSP findsp;

        public CFindSP()
        {
            findsp = new EFindSP();
        }

        public DataTable FindSP(string TenSP)
        {
            return findsp.FindSP(TenSP);
        }
    }
}
