using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucThe;
namespace DieuKhien
{
    public class CAddMay
    {
        private EAddMay edd;

        public CAddMay()
        {
            edd = new EAddMay();
        }

        public bool AddMay(string IDMay, string TenMay)
        {
            return edd.AddMay(IDMay, TenMay);
        }
    }
}
