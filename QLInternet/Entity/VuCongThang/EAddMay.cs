using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EAddMay
    {
        private ConnectSQL connect;

        public EAddMay()
        {
            connect = new ConnectSQL();
        }

        public bool AddMay(string IDMay, string TenMay)
        {
            return connect.AddMay(new EMay(IDMay, TenMay));
        }
    }
}