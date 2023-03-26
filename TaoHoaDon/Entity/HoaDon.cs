using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entity
{
    public class HoaDon
    {
        private string chuoiketnoi = "Data Source=DESKTOP-HEOM7SP;Initial Catalog=INTERNET;Integrated Security=True";
        private SqlConnection conn = null;
        public HoaDon(){
            conn = new SqlConnection(chuoiketnoi);
        }

        private void OpenConnect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetMon()
        {
            string query = "SELECT * FROM SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            return dt1;
        }

        public int AddHD(double tongtien)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "INSERT INTO Hoadon (NgayLap, tongtien) VALUES (@NgayLap, @tongtien); SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@NgayLap", DateTime.Now);
            command.Parameters.AddWithValue("@tongtien", tongtien);
            con.Open();
            int maHD = (int)command.ExecuteScalar();
            con.Close();
            return maHD;
        }

        public void inserttoHD(int maHD, string ID, int soLuong)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sql = "INSERT INTO Cthoadon VALUES (@MaHD, @ID, @SoLuong)";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@MaHD", maHD);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void CapNhatSLBan(string IDSP, int soLuong)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string selectQuery = "SELECT SCOPE_IDENTITY()";
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);
            string updateQuery = "UPDATE sanpham SET slton = slTon - @SoLuong WHERE IDSP = @IDSP";
            SqlCommand updateCommand = new SqlCommand(updateQuery, con);
            con.Open();
            updateCommand.Parameters.AddWithValue("@SoLuong", soLuong);
            updateCommand.Parameters.AddWithValue("@IDSP", IDSP);
            updateCommand.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DoAn(ESanPham sp)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM SanPham WHERE TenSP like N'%" + sp.TenSP + "%' or TenSP like N'%" + sp.TEnSP + "%'";
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataTable DoUong(ESanPham sp)
        {
            DataTable dt1 = new DataTable();
            string query = "SELECT * FROM SanPham WHERE TenSP like N'%" + sp.TenSP + "%'";
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt1);
            CloseConnect();
            return dt1;
        }

        public DataTable The(ESanPham sp)
        {
            DataTable dt2 = new DataTable();
            string query = "SELECT * FROM SanPham WHERE TenSP like N'%" + sp.TenSP + "%'";
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt2);
            CloseConnect();
            return dt2;
        }

        public DataTable FindSP(ESanPham sp)
        {
            string query = "SELECT * FROM SanPham WHERE TenSP like N'%" + sp.TenSP + "%'";
            DataTable dt0 = new DataTable();
            OpenConnect();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt0);
            CloseConnect();
            return dt0;
        }

        public bool AddSP(ESanPham sp)
        {
            string query = "INSERT INTO SanPham VALUES(@idsp, @tensp, @giaban, @sl)";
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsp", sp.IDSP);
            cmd.Parameters.AddWithValue("@tensp", sp.TenSP);
            cmd.Parameters.AddWithValue("@giaban", sp.GiaBan);
            cmd.Parameters.AddWithValue("@sl", sp.SLTon);
            bool check = false;
            if (cmd.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            CloseConnect();
            return check;
        }

        public bool XoaSP(string id)
        {
            string query = "DELETE SanPham WHERE IDSP = @id";
            OpenConnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            bool check = false;
            if (cmd.ExecuteNonQuery() == 1)
            {
                check = true;
            }
            return check;
        }

        public bool CheckSP(string id)
        {
            string truyvan = "SELECT * FROM SanPham WHERE IDSP = @id";
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            OpenConnect();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = false;
            if(reader.Read())
            {
                check = true;
            }
            CloseConnect();
            return check;
        }
    }
}
