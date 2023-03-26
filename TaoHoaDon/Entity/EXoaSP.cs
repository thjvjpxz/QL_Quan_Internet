using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EXoaSP
    {
        HoaDon hd;

        public EXoaSP()
        {
            hd = new HoaDon();
        }

        public bool XoaSP(string id)
        {
            return hd.XoaSP(id);
        }
    }
}
