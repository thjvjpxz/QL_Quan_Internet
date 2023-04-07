using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public class EFindSP
    {
        HoaDon connn;

        public EFindSP()
        {
            connn = new HoaDon();
        }

        public DataTable FindSP(string TenSP){
            return connn.FindSP(new ESanPham(TenSP));
        }
    }
}
