using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entity
{
    public class ETrangThaiMayTinh
    {
        string strConn = "Data Source=DESKTOP-BED894K;Initial Catalog=QLINTERNET;Integrated Security=True";
        SqlConnection conn = null;

        public ETrangThaiMayTinh()
        {
            conn = new SqlConnection(strConn);
        }

        private void OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetInfoPC()
        {
            // Xem thông tin của máy
            conn.Open();

            string query = "Select IDMay, TenMay, TrangThai, SoTG, PhuongThucDung, SoTien from May";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable dulieu = new DataTable();
            ada.Fill(dulieu);
            conn.Close();
            return dulieu;
        }

        public void TatMay(string id)
        {
            // Tắt máy
            conn.Open();

            string query = "update May set TrangThai = N'Tắt' where IDMay = @idd";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idd", id);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public bool MoMay(string id, string timeStart)
        {
            // Mở máy
            OpenConn();

            string query = "update May set TrangThai = N'Mở', PhuongThucDung = N'Trả sau', TimeStart = @time where IDMay = @idd";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@time", timeStart);
            cmd.Parameters.AddWithValue("@idd", id);

            bool check = cmd.ExecuteNonQuery() == 1;

            CloseConn();
            return check;
        }

        public bool DongMay(string id, int giay, out double tongTien)
        {
            tongTien = Math.Round(QuyDoiGiayTien(giay), 2);
            OpenConn();

            string query = "update May set TrangThai = N'Bật', PhuongThucDung = N'Không có', ";
            query += "TimeStart = '2000-01-01 00:00:00', SoTien = 0 where IDMay = @idd";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idd", id);
            cmd.Parameters.AddWithValue("@tien", tongTien);

            bool check = cmd.ExecuteNonQuery() == 1;

            CloseConn();

            return check;
        }

        public void GetTimeStart(string id, out DateTime time)
        {
            // lấy thời gian bắt đầu
            // Hàm hỗ trợ
            OpenConn();

            string query = "select TimeStart from May where IDMay = @idd";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idd", id);

            SqlDataReader reader = cmd.ExecuteReader();
            time = new DateTime(1900, 01, 01, 0, 0, 0);
            if (reader.HasRows && reader.Read())
                time = reader.GetDateTime(0);
            reader.Close();
            CloseConn();
        }

        public static double QuyDoiGiayTien(int giay) 
        {
            double OneS = (double)5000 / 3600;
            return Math.Round(OneS * giay, 2);
        }
    }
}
