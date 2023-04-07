using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    public class CAddSP
    {
        EAddSanPham eaddsp;
        
        public CAddSP(){
            eaddsp = new EAddSanPham();
        }

        public bool AddSP(string id, string ten, int gia, int sl){
            return eaddsp.AddSP(id, ten, gia, sl);
        }
    }
}
