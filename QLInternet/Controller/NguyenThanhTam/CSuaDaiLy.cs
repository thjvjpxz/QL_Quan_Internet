using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CSuaDaiLy
    {
        ESuaDaiLy suadaily;

        public CSuaDaiLy()
        {
            suadaily = new ESuaDaiLy();
        }

        public bool SuaDaiLy(string maDaiLy, string tenDaiLy, string diaChi)
        {
            return suadaily.SuaDaiLy(maDaiLy, tenDaiLy, diaChi);
        }
    }
}
