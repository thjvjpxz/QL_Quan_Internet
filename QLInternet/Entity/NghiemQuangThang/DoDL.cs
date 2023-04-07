using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaiKhoan
{
    public class DoDL
    {
        private TaiKhoan conn;
        public DoDL()
        {
            conn = new TaiKhoan();
        }
        public DataTable DoDL1()
        {
            return conn.DoDL1();
        }
    }
}
