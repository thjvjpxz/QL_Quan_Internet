using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entity
{
    public class ENT // DaiLyDAL
    {
        string connectionString = "Data Source=DESKTOP-BED894K;Initial Catalog=QLINTERNET;Integrated Security=True";
        public DataTable GetAllDaiLy()
        {
            string query = "select * from DaiLy";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                return datatable;
            }
        }
        public void ThemDaiLy(string maDaiLy, string tenDaiLy, string diaChi)
        {
            string query = "insert into DaiLy (MaDL, TenDL, DiaChi) values (@maDaiLy, @tenDaiLy, @diaChi)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maDaiLy", maDaiLy);
                command.Parameters.AddWithValue("@tenDaiLy", tenDaiLy);
                command.Parameters.AddWithValue("@diaChi", diaChi);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public bool SuaDaiLy(string maDaiLy, string tenDaiLy, string diaChi)
        {
            string query = "update DaiLy set TenDL = @tenDaiLy, DiaChi = @diaChi where MaDL = @maDaiLy";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maDaiLy", maDaiLy);
                command.Parameters.AddWithValue("@tenDaiLy", tenDaiLy);
                command.Parameters.AddWithValue("@diaChi", diaChi);
                bool check = false;
                check = command.ExecuteNonQuery() == 1;
                return check;
            }
        }

        public bool XoaDaiLy(DaiLy dl)
        {
            string query = "delete from DaiLy where MaDL = @maDaiLy";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maDaiLy", dl.maDaiLy);
                bool check = false;
                check = command.ExecuteNonQuery() == 1;
                return check;
            }
        }

        public void XoaDaiLy(string maDaiLy)
        {
            throw new NotImplementedException();
        }
        public DataSet TimKiemDL(string tenDaiLy)
        {
            string query = "select * from DaiLy where TenDL like '%' + @tenDaiLy + '%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenDaiLy", tenDaiLy);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }
    }
}
