using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKhoan;

namespace Controller
{
    public class CDoiMK
    {
        private EDoiMK doi;
        public CDoiMK()
        {
            doi = new EDoiMK();
        }
        public void doimk(string username, string pass)
        {
            doi.doimk(username, pass);
        }
    }
}
