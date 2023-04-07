using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ESanPham
    {
        public string IDSP { get; set; }

        public string TenSP { get; set; }

        public int GiaBan { get; set; }

        public int SLTon { get; set; }

        public string TEnSP { get; set; }
        public ESanPham(string idSP, string tenSP, int giaBan, int slTon)
        {
            IDSP = idSP;
            TenSP = tenSP;
            GiaBan = giaBan;
            SLTon = slTon;
        }

        public ESanPham(string tenSP)
        {
            TenSP = tenSP;
        }

        public ESanPham(string tenSP, string tensp)
        {
            TenSP = tenSP;
            TEnSP = tensp;
        }
    }
}
