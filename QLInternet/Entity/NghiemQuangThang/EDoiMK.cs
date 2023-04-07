using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoan
{
    public class EDoiMK
    {
        TaiKhoan doi;
        public EDoiMK()
        {
            doi = new TaiKhoan();
        }
        public void doimk(string username, string pass)
        {
            doi.doimk(username, pass);
        }
    }
}
