using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKhoan;
using System.Data;

namespace Controller
{
    public class CSearch
    {
        private ESearch tim;
        public CSearch()
        {
            tim = new ESearch();
        }
        public DataTable Search(string username)
        {
            return tim.Search(username);
        }
    }
}
