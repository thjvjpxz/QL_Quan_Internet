using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Controller
{
    public class CGetBangThe
    {
        EGetBangThe getbangthe;

        public CGetBangThe()
        {
            getbangthe = new EGetBangThe();
        }

        public DataTable The(string TenSP)
        {
            return getbangthe.The(TenSP);
        }
    }
}
