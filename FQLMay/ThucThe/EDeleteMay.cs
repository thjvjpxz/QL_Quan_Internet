using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucThe
{
    public class EDeleteMay
    {
        ConnectSQL connectt;

        public EDeleteMay(){
            connectt = new ConnectSQL();
        }

        public bool DeleteMay(string IDMay)
        {
            return connectt.DeleteMay(new EMay(IDMay));
        }
    }
}
