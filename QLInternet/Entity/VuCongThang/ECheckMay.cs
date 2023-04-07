using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ECheckMay
    {
            private ConnectSQL connectsql;
            public ECheckMay()
            {
                connectsql = new ConnectSQL();
            }

            public bool checkMay(string IDMay)
            {
                return connectsql.checkMay(IDMay);
            }
        }
    }
