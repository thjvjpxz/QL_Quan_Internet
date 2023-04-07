using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EUpdateMay
    {
        ConnectSQL connection;

        public EUpdateMay()
        {
            connection = new ConnectSQL();
        }

        public bool UpdateMay(string IDMay, string TenMay)
        {
            return connection.UpdateMay(new EMay(IDMay, TenMay));
        }
    }
}
