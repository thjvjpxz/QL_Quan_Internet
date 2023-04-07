using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EAddSanPham
    {
        HoaDon hd;

        public EAddSanPham()
        {
            hd = new HoaDon();
        }

        public bool AddSP(string id, string ten, int gia, int sl)
        {
            return hd.AddSP(new ESanPham(id, ten, gia, sl));
        }
    }
}
