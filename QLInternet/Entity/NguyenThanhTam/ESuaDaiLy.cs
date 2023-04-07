using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity
{
    public class ESuaDaiLy
    {
        ENT ent;

        public ESuaDaiLy()
        {
            ent = new ENT();
        }

        public bool SuaDaiLy(string maDaiLy, string tenDaiLy, string diaChi)
        {
            return ent.SuaDaiLy(maDaiLy, tenDaiLy, diaChi);
        }
    }
}
