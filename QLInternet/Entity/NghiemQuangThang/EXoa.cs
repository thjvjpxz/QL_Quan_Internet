using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoan
{
    public class EXoa
    {
        private TaiKhoan conn;
        public EXoa()
        {
            conn = new TaiKhoan();
        }
        public void xoatk(string username)
        {
             conn.xoatk(username);
        }
    }
}
