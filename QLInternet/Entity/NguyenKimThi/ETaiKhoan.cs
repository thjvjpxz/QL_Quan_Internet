using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entity
{
    public class ETaiKhoan
    {

        public string strConn = "Data Source=DESKTOP-BED894K;Initial Catalog=QLINTERNET;Integrated Security=True";
        SqlConnection conn = null;

        public ETaiKhoan()
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

        public int LayTienBanDau(string user)
        {
            // Số tiền ban đầu của 1 user
            // Hàm hỗ trợ cho CongTien và TruTien
            OpenConn();
            string query = "select SoTienHienCo from TaiKhoan where UserName = @us";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@us", user);

            SqlDataReader reader = cmd.ExecuteReader();
            int soTien = 0;
            if (reader.HasRows && reader.Read())
                soTien = reader.GetInt32(0);
            reader.Close();
            CloseConn();
            return soTien;
        }

        public static int QuyDoiTienPhut(double soTien)
        {
            double oneDongoneMin = (double)12 / 1000; // 1 đồng sang 1 phút

            return (int)Math.Round(soTien * oneDongoneMin, 2);
        }

        public bool CongTien(string tk, int soTienThem)
        {
            // Nạp thêm tiền
            int TongTien = LayTienBanDau(tk) + soTienThem;
            int soPhut = ETaiKhoan.QuyDoiTienPhut(TongTien);
            OpenConn();
            string query = "update TaiKhoan set SoTienHienCo = @tien, SoPhut = @phut where UserName = @user";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tien", TongTien);
            cmd.Parameters.AddWithValue("@phut", soPhut);
            cmd.Parameters.AddWithValue("@user", tk);

            bool check = cmd.ExecuteNonQuery() == 1;
            CloseConn();
            return check;
        }

        public bool TruTien(string tkChuyen, int soTienChuyen, string tkNhan)
        {
            // Chuyển tiền
            int accChuyenHienCo = LayTienBanDau(tkChuyen);
            int accNhanHienCo = LayTienBanDau(tkNhan);
            int soPhutChuyen;
            int soPhutNhan;
            if (accChuyenHienCo <= soTienChuyen || soTienChuyen % 1000 != 0)
                return false;
            else
            {
                int TienTKChuyen = accChuyenHienCo - soTienChuyen; // Số tiền tài khoản chuyển còn lại
                int TienTKNhan = accNhanHienCo + soTienChuyen;
                // Tổng số phút tài khoản chuyển
                soPhutChuyen = ETaiKhoan.QuyDoiTienPhut(TienTKChuyen);
                // Tổng số phút tài khoản chuyển
                soPhutNhan = ETaiKhoan.QuyDoiTienPhut(TienTKNhan);
                OpenConn();

                string queryChuyen = "update TaiKhoan set SoTienHienCo = @tiencon, SoPhut = @phut where UserName = @userChuyen";
                string queryNhan = "update TaiKhoan set SoTienHienCo = @tiennhan, SoPhut = @phutt where UserName = @userNhan";

                SqlCommand cmdChuyen = new SqlCommand(queryChuyen, conn);
                SqlCommand cmdNhan = new SqlCommand(queryNhan, conn);

                cmdChuyen.Parameters.AddWithValue("@tiencon", TienTKChuyen);
                cmdChuyen.Parameters.AddWithValue("@phut", soPhutChuyen);
                cmdChuyen.Parameters.AddWithValue("@userChuyen", tkChuyen);

                cmdNhan.Parameters.AddWithValue("@tiennhan", TienTKNhan);
                cmdNhan.Parameters.AddWithValue("@phutt", soPhutNhan);
                cmdNhan.Parameters.AddWithValue("@userNhan", tkNhan);

                bool check = cmdChuyen.ExecuteNonQuery() == 1 && cmdNhan.ExecuteNonQuery() == 1;

                CloseConn();
                return check;
            }
        }

        public DataTable XemTTNapTien()
        {
            // Xem thông tin nạp tiền
            conn.Open();

            string query = "select UserName, SoPhut, SoTienHienCo from TaiKhoan";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            conn.Close();
            return dt;
        }


    }
}
