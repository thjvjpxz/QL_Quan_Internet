using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace Controller
{
    public class CNapTien
    {
        ETaiKhoan connTK;   // connection taikhoan

        public CNapTien()
        {
            connTK = new ETaiKhoan();
        }

        public DataTable XemTTNapTien()
        {
            return connTK.XemTTNapTien();
        }

        public bool CongTien(string tk, int soTienThem)
        {
            return connTK.CongTien(tk, soTienThem);
        }

        public bool TruTien(string tkChuyen, int soTienChuyen, string tkNhan)
        {
            return connTK.TruTien(tkChuyen, soTienChuyen, tkNhan);
        }
    }
}
