using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Controller
{
    public class CGetBangDoUong
    {
        EGetBangDoUong getbangdouong;

        public CGetBangDoUong()
        {
            getbangdouong = new EGetBangDoUong();
        }

        public DataTable DoUong(string TenSP)
        {
            return getbangdouong.DoUong(TenSP);
        }
    }
}
