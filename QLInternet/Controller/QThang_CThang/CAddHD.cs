using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Controller
{
    public class CAddHD
    {
        EAddHD add;
        public CAddHD()
        {
            add = new EAddHD();
        }

        public int AddHD(double tongtien)
        {
            return add.AddHD(tongtien);
        }
    }
}
