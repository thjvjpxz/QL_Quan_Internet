using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DaiLy
    {
        public string maDaiLy { get; set; }

        public string tenDaiLy { get; set; }

        public string diaChi { get; set; }

        public DaiLy(string madl, string ten, string dc)
        {
            maDaiLy = madl;
            tenDaiLy = ten;
            diaChi = dc;
        }

        public DaiLy(string madl)
        {
            maDaiLy = madl;
        }
    }
}
