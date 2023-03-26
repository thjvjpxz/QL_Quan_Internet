using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EGetBangDoAn
    {
        HoaDon conn;

        public EGetBangDoAn()
        {
            conn = new HoaDon();
        }

        public DataTable DoAn(string TenSP, string TEnSP)
        {
            return conn.DoAn(new ESanPham(TenSP, TEnSP));
        }
    }
}
