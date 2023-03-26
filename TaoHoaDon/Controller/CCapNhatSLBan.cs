using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CCapNhatSLBan
    {
        ECapNhatSLBan ecapnhatsl;

        public CCapNhatSLBan()
        {
            ecapnhatsl = new ECapNhatSLBan();
        }

        public void CapNhatSLBan(string idsp, int soluong)
        {
            ecapnhatsl.CapNhatSLBan(idsp , soluong);
        }
    }
}
