using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entity
{
    public class ent_thongke
    {
        // kết nối sql
        string connectionString = "Data Source=DESKTOP-BED894K;Initial Catalog=QLINTERNET;Integrated Security=True";
        // liệt kê tất cả các sản phẩm
        public DataTable SanPham()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from SanPham";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        // Liệt kê idDaiLy
        public DataTable IDDaiLy()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select MaDL from DaiLy";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Liệt kê idSP
        public DataTable GetIDSP()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select IDSP from SanPham";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // lệnh truy vấn các sản phẩm có số lượng tồn nhỏ hơn 5
        public DataTable SanPhamTon()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select IDSP, TenSP, SLTon from SanPham where SLTon < 5";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        // Tất cả phiếu nhập, hiển thị các thông tin của phiếu nhập
        public DataTable GetALLPhieuNhap()
        {
            string query = "select phieunhap.IDPhieu as 'Mã Phiếu', MaDL as 'Mã đại lý', IDSP as 'Mã đồ ăn/uống', SoLuong as 'Số Lượng sau khi nhập', NgaytaoPhieu as 'Ngày tạo phiếu' from PhieuNhap INNER JOIN CTPHIEUNHAP on phieunhap.idphieu = ctphieunhap.idphieu";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                return datatable;
            }
        }
        // Thêm phiếu nhập
        public int AddPHieuNhap(double tongtien, string MaDL)
        {

            string sql = "INSERT INTO PhieuNhap (NgaytaoPhieu, tongtien, MaDL) VALUES (@NgaytaoPhieu, @tongtien, @MaDL); SELECT CAST(scope_identity() AS int)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NgaytaoPhieu", DateTime.Now);
            command.Parameters.AddWithValue("@tongtien", tongtien);
            command.Parameters.AddWithValue("@maDL", MaDL);
            connection.Open();
            int IDPhieu = (int)command.ExecuteScalar();
            connection.Close();
            return IDPhieu;
            }
        }
        // Điền phiếu nhập
        public void InsertPhieuNhap(int IDPhieu, string IDSP, int soLuong, double GiaBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO CTPhieuNhap VALUES (@IDPhieu, @IDSP, @SoLuong, @GiaBan)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IDPhieu", IDPhieu);
                command.Parameters.AddWithValue("@IDSP", IDSP);
                command.Parameters.AddWithValue("@SoLuong", soLuong);
                command.Parameters.AddWithValue("@GiaBan", GiaBan);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        // Cộng số lượng tồn với số lượng thêm vào
        public void updateSP(string IDSP, int soluongthem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "update sanpham set slton = slton + @soluongthem where idsp = @IDSP";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IDSP", IDSP);               
                command.Parameters.AddWithValue("@soluongthem", soluongthem);            
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
