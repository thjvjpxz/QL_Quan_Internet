using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ECheckSP
    {

        HoaDon hd;

        public ECheckSP()
        {
            hd = new HoaDon();
        }

        public bool CheckSP(string id)
        {
            return hd.CheckSP(id);
        }
    }
}
