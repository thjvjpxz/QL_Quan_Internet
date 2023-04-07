using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CXoaDaiLy
    {
        EXoaDaiLy xoasp;

        public CXoaDaiLy()
        {
            xoasp = new EXoaDaiLy();
        }

        public bool XoaDaiLy(string id)
        {
            return xoasp.XoaDaiLy(id);
        }
    }
}
