using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EXoaDaiLy
    {
        ENT ent;
        public EXoaDaiLy()
        {
            ent = new ENT();
        }

        public bool XoaDaiLy(string maDaiLy)
        {
            return ent.XoaDaiLy(new DaiLy(maDaiLy));
        }
    }
}
