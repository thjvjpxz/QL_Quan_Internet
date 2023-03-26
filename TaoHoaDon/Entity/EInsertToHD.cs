using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity
{
    public class EInsertToHD
    {
        HoaDon a;
        public EInsertToHD()
        {
            a = new HoaDon();
        }

        public void insertToHD(int mahd, string ID, int sl)
        {
            a.inserttoHD(mahd, ID, sl);
        }
    }
}
