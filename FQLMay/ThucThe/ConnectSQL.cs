using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ThucThe
{
    class ConnectSQL
    {  
        private string conStr = @"Data Source=LAPTOP-VPEHGS0I\MSSQLSERVER01;Initial Catalog=QLMay;Integrated Security=True";
        private SqlConnection conn = null;
        public ConnectSQL(){
            conn = new SqlConnection(conStr);
        }



        public bool checkMay(string id)
        {
            OpenConnect();
            string query = "SELECT IDMay FROM May WHERE IDMay = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            bool check = false;
            if (reader.HasRows)
            {
                check = true;
            }
            reader.Close();
            CloseConnect();

            return check;
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
     
        public bool AddMay(EMay may)
        {
            if(checkMay(may.IDMay))
            {
                return false;
            }
            OpenConnect();
            string query = "INSERT INTO May(IDMay, TenMay) VALUES (@id, @ten)"; 

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", may.IDMay);
            cmd.Parameters.AddWithValue("@ten", may.TenMay);

            bool check = cmd.ExecuteNonQuery() == 1;

            CloseConnect();
            return check;
        }

        public DataTable GetBang()
        {
            
            string query = "SELECT * FROM May";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool UpdateMay(EMay may)
        {
            string query = "UPDATE May SET TenMay = @ten WHERE IDMay = @id";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnect();
                cmd.Parameters.AddWithValue("@id", may.IDMay);
                cmd.Parameters.AddWithValue("@ten", may.TenMay);
                cmd.ExecuteNonQuery();
                CloseConnect();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        public bool DeleteMay(EMay may)
        {
            string query = "DELETE May WHERE IDMay = @id";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                OpenConnect();
                cmd.Parameters.AddWithValue("id", may.IDMay);
                cmd.ExecuteNonQuery();
                CloseConnect();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable FindMay(EMay may)
        {
                string query = "SELECT * FROM May WHERE IDMay like '%"+may.IDMay+"%'";
                DataTable dt0 = new DataTable();
                OpenConnect();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt0);
                CloseConnect();
                return dt0;
        }

        internal object UpdateMay(string TenMay)
        {
            throw new NotImplementedException();
        }
    }
}
