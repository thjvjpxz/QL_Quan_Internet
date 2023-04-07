using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKhoan;
namespace Controller
{
    public class CXoa
    {
        private EXoa xoa;
        public CXoa()
        {
            xoa = new EXoa();
        }
        public void xoatk(string username)
        {
             xoa.xoatk(username);
        }
    }
}
