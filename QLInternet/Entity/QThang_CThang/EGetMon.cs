using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EGetMon
    {
        HoaDon hd;
        public EGetMon()
        {
            hd = new HoaDon();
        }
        public DataTable GetMon()
        {
            return hd.GetMon();
        }
    }
}
