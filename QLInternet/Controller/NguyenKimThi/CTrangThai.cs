using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace Controller
{
    public class CTrangThai
    {
        ETrangThaiMayTinh connTT;   // connection trangthai
        

        public CTrangThai()
        {
            connTT = new ETrangThaiMayTinh();
        }

        public DataTable GetInfoPC()
        {
            return connTT.GetInfoPC();
        }

        public void TatMay(string id)
        {
            connTT.TatMay(id);
        }

        public bool MoMay(string id, string timeStart)
        {
            return connTT.MoMay(id, timeStart);
        }

        public bool DongMay(string id, int giay, out double tongTien)
        {
            return connTT.DongMay(id, giay, out tongTien);
        }

        public void GetTimeStart(string id, out DateTime time)
        {
            connTT.GetTimeStart(id, out time);
        }

        public static double QuyDoiGiayTien(int giay)
        {
            return ETrangThaiMayTinh.QuyDoiGiayTien(giay);
        }
    }
}
