using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKhoan;
using System.Data;

namespace Controller
{
    public class CDoDL
    {
        private DoDL doc;
        public CDoDL()
        {
            doc = new DoDL();
        }
        public DataTable DoDL1()
        {
            return doc.DoDL1();
        }
    }
}
