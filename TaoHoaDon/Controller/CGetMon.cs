using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace Controller
{
    public class CGetMon
    {
        EGetMon gm;
        public CGetMon()
        {
            gm = new EGetMon();
        }

        public DataTable GetMon()
        {
            return gm.GetMon();
        }
    }
}
