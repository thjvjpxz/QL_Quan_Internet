using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class EMay
    {
        public string IDMay { get; set; }

        public string TenMay { get; set; }
        public EMay(string idMay, string tenMay)
        {
            IDMay = idMay;
            TenMay = tenMay;
        }

        public EMay(string idMay)
        {
            IDMay = idMay;
        }
    }
}
