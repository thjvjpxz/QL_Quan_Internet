using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucThe;
namespace DieuKhien
{
    public class CDeleteMay
    {
        EDeleteMay edelete;

        public CDeleteMay()
        {
            edelete = new EDeleteMay();
        }

        public bool DeleteMay(string IDMay)
        {
            return edelete.DeleteMay(IDMay);
        }
    }
}
