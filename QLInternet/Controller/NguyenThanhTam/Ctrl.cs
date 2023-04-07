using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System;
using System.Data;


namespace Controller
{
    public class Ctrl
    {
        ENT entDaiLy = new ENT();
        public DataTable GetAllDaiLy()
        {
            return entDaiLy.GetAllDaiLy();
        }
        public void ThemDaiLy(string maDaiLy, string tenDaiLy, string diaChi)
        {
            if (string.IsNullOrEmpty(maDaiLy) || string.IsNullOrEmpty(tenDaiLy) || string.IsNullOrEmpty(diaChi))
            {
                throw new Exception("Thông tin đại lý không được để trống!");
            }
            else
            {
                entDaiLy.ThemDaiLy(maDaiLy, tenDaiLy, diaChi);
            }
        }

        public void XoaDaiLy(string maDaiLy)
        {
            entDaiLy.XoaDaiLy(maDaiLy);
        }
        public DataSet TimKiemDL(string tenDaiLy)
        {
            DataSet dataset = entDaiLy.TimKiemDL(tenDaiLy);
            return dataset;
        }
    }
}
