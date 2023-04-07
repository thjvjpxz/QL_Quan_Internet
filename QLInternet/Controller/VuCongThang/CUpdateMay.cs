using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Controller
{
    public class CUpdateMay
    {
        EUpdateMay eupdate;

        public CUpdateMay()
        {
            eupdate = new EUpdateMay();
        }

        public bool UpdateMay(string IDMay, string TenMay)
        {
            return eupdate.UpdateMay(IDMay, TenMay);
        }
    }
}
