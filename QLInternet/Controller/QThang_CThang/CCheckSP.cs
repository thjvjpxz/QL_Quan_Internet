using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CCheckSP
    {
        ECheckSP echecksp;

        public CCheckSP()
        {
            echecksp = new ECheckSP();
        }

        public bool CheckSP(string id)
        {
            return echecksp.CheckSP(id);
        }
    }
}
