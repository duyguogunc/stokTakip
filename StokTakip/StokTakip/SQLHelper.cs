using System.Data;
using System.Data.SqlClient;

namespace StokTakip
{
    class SQLHelper
    {
        private string ConnectionString { get; set; }
        private SqlConnection Connection { get; set; }

        public SQLHelper()
        {
            ConnectionString = @"Server=Wissen\SQLEXPRESS;
                                Database=StockManagement;
                                User ID = Section1;
                                Trusted_Connection=true;";
            Connection = new SqlConnection(ConnectionString);
        }

        public int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            int r = command.ExecuteNonQuery();
            Connection.Close();
            return r;
        }

        public void ExecuteProc(string procName, int? Id = null)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            if (Id.HasValue)
                command.Parameters.AddWithValue("ID", Id.Value);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void ExecuteProc(string procName,params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
