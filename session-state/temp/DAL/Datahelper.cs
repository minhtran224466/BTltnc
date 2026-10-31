using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLySinhVien.Data.DAL
{
    public class DataHelper
    {
        private SqlConnection con;
        string connectionString;

        public DataHelper()
        {
            // Cậu nhớ kiểm tra lại tên Server bên trong chuỗi kết nối cho khớp với máy của cậu nhé
            this.connectionString = @"Server=LAPTOP-6SN65NCS\HUECTMDB; Database=QLSV; Integrated Security=True; TrustServerCertificate=true";
            con = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Dùng cho các câu lệnh INSERT, UPDATE, DELETE
        public void ExecuteNonQuery(string sqlExcuteQuery)
        {
            try
            {
                OpenConnection();
                SqlCommand comand = new SqlCommand(sqlExcuteQuery, con);
                comand.ExecuteNonQuery();
                comand.Dispose();
                CloseConnection();
            }
            catch (Exception exx)
            {
                throw new Exception(exx.Message);
            }
        }

        // Dùng cho việc lấy dữ liệu trả về kiểu SqlDataReader
        public SqlDataReader ExcuteReader(string sqlSelect)
        {
            OpenConnection();
            SqlCommand comand = new SqlCommand(sqlSelect, con);
            SqlDataReader red = comand.ExecuteReader(CommandBehavior.CloseConnection);
            return red;
        }

        // Dùng cho việc đổ dữ liệu vào DataTable (dùng rất nhiều cho DataGridView và ComboBox)
        public DataTable GetDataTable(String sqlSelect)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}