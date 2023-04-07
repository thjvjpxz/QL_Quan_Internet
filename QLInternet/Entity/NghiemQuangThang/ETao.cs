using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoan
{
    public class ETao
    {
        TaiKhoan conn;
        public ETao()
        {
            conn = new TaiKhoan();
        }
        public bool taotk(string username, string pass)
        {
             return conn.taotk(username, pass);
        }
    }
}
