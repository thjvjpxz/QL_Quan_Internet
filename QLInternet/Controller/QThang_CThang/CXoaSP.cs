using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CXoaSP
    {
        EXoaSP exoasp;

        public CXoaSP()
        {
            exoasp = new EXoaSP();
        }

        public bool XoaSP(string id)
        {
            return exoasp.XoaSP(id);
        }
    }
}
