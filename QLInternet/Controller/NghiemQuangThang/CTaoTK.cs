using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKhoan;
using System.Data.SqlClient;
namespace Controller
{
    public class CTaoTK
    {
        ETao tao;
        public CTaoTK()
        {
            tao = new ETao();
        }
        public bool taotk(string username, string pass)
        {
            return tao.taotk(username, pass);
        }
    }
}
