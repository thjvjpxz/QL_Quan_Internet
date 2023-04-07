using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EGetBangThe
    {
        HoaDon conn;

        public EGetBangThe()
        {
            conn = new HoaDon();
        }

        public DataTable The(string TenSP)
        {
            return conn.The(new ESanPham(TenSP));
        }
    }
}
