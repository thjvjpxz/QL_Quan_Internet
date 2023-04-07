using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EGetBangDoUong
    {
        HoaDon conn;

        public EGetBangDoUong()
        {
            conn = new HoaDon();
        }

        public DataTable DoUong(string TenSP)
        {
            return conn.DoUong(new ESanPham(TenSP));
        }
    }
}
