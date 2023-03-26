using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Controller
{
    public class CGetBangDoAn
    {
        EGetBangDoAn getbangdoan;

        public CGetBangDoAn()
        {
            getbangdoan = new EGetBangDoAn();
        }

        public DataTable DoAn(string TenSP, string TEnSP)
        {
            return getbangdoan.DoAn(TenSP, TEnSP);
        }
    }
}
