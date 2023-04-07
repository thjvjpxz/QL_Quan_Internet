using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace Controller
{
    public class ctrl_thongke
    {
        private ent_thongke ent_tke;

        public ctrl_thongke()
        {
            ent_tke = new ent_thongke();
        }

        public DataTable SanPham()
        {
            return ent_tke.SanPham();
        }

        public DataTable SanPhamTon()
        {
            return ent_tke.SanPhamTon();
        }
        public int AddPhieuNhap(double tongtien, string MaDL)
        {
            return ent_tke.AddPHieuNhap(tongtien, MaDL);
        }
        public void InsertPhieuNhap(int IDPhieu, string IDSP, int soLuong, double GiaBan)
        {
           ent_tke.InsertPhieuNhap(IDPhieu, IDSP, soLuong, GiaBan);
        }
        public DataTable GetALLPhieuNhap()
        {
            return ent_tke.GetALLPhieuNhap();
        }
        public void updateSP(string IDSP, int soluong)
        {
            ent_tke.updateSP(IDSP, soluong);
        }

        public DataTable IDDaiLy()
        {
            return ent_tke.IDDaiLy();
        }
        public DataTable GetIDSP()
        {
            return ent_tke.GetIDSP();
        }
    }
}
