using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ECapNhatSLBan
    {
        HoaDon hd;

        public ECapNhatSLBan()
        {
            hd = new HoaDon();
        }

        public void CapNhatSLBan(string IDSP, int soluong)
        {
            hd.CapNhatSLBan(IDSP, soluong);
        }
    }
}
