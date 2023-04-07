using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TaiKhoan
{
    public class TaiKhoan
    {
        private string chuoiketnoi = "Data Source=DESKTOP-BED894K;Initial Catalog=QLINTERNET;Integrated Security=True";

        public bool taotk(string username, string pass)
        {
            if (check(username))
            {
                return false;
            }
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TaiKhoan(Username, pass) VALUES(@username, @pass)", conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@pass", pass);
                command.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }
        private bool check(string username)
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {

                SqlCommand command = new SqlCommand("Select count(*) from TaiKhoan where username = @username", conn);
                command.Parameters.AddWithValue("@username", username);
                conn.Open();
                int count = (int)command.ExecuteScalar();
                conn.Close();
                return count > 0;
            }
        }
        public void xoatk(string username)
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from TaiKhoan where username = @username", conn);
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void doimk(string username, string pass)
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("update taikhoan set pass = @pass where username = @username", conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@pass", pass);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable Search(string username)
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                string sql = "Select UserName as'Tài khoản', SoPhut as'Số Phút', SoTienHienCo as'Số Tiền', DayLgEnd as 'Ngày đăng nhập cuối cùng' from TaiKhoan where username like '%"+username+"%'";
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public DataTable DoDL1()
        {
            using (SqlConnection conn = new SqlConnection(chuoiketnoi))
            {
                conn.Open();
                string sql = "Select UserName as'Tài khoản', SoPhut as'Số Phút', SoTienHienCo as'Số Tiền hiện có', DayLgEnd as 'Ngày đăng nhập cuối cùng' from TaiKhoan";
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                conn.Close();
                return dt;
            }
        }


    }
}
