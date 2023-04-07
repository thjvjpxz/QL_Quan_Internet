using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Entity
{
    public class EAddHD
    {
        HoaDon hd;
        public EAddHD()
        {
            hd = new HoaDon();
        }
        public int AddHD(double tongtien)
        {
            return hd.AddHD(tongtien);
        }
    }
}
