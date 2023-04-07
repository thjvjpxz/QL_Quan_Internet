using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EGetInfo
    {
        ConnectSQL conn;

        public EGetInfo()
        {
            conn = new ConnectSQL();
        }

        public DataTable gettt()
        {
            return conn.GetBang();
        }
    }
}
