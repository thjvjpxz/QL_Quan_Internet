using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TaiKhoan
{
    public class ESearch
    {
        TaiKhoan conn;
        public ESearch()
        {
            conn = new TaiKhoan();
        }
        public DataTable Search(string username)
        {
             return conn.Search(username);
        }
    }
}
