using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucThe;
using System.Data;


namespace DieuKhien
{
    public class GetThongTIn
    {
        EGetInfo get;

        public GetThongTIn()
        {
            get = new EGetInfo();
        }

        public DataTable gettt() {
            return get.gettt();
        }
    }
}
