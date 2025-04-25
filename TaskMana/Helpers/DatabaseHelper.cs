using System;
using System.Data;
using System.Data.SqlClient;

namespace TaskMana.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=.;Initial Catalog=TaskManaDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
