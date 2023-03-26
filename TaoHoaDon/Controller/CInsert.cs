using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CInsert
    {
        EInsertToHD a;
        public CInsert()
        {
            a = new EInsertToHD();
        }

        public void insert(int ma, int id, int sl)
        {
            a.insertToHD(ma, id, sl);
        }
    }
}
