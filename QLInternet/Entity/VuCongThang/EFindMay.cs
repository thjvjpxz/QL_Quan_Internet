using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EFindMay
    {
        ConnectSQL connn;

        public EFindMay()
        {
            connn = new ConnectSQL();
        }

        public DataTable FindMay(string IDMay){
            return connn.FindMay(new EMay(IDMay));
        }
    }
}
