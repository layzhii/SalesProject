using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SalesProject.Classes
{
    public class DataBaseCmd
    {
        public static string connectionString;

        static SqlConnection sqlConnection;

        static string SQLServerName = "localhost";
        
        static string dbName = "SalesDB";


        public static async void Connect()
        {
            connectionString = $"Server={SQLServerName};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                 await sqlConnection.OpenAsync();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);

                if (dt.Rows.Count > 0)
                    return dt;
                else
                    return null;
            }
        }

        public static async Task<DataTable> ExecuteQuery(string query, DataTable dt1, DataTable dt2, DateTime date1, DateTime date2)
        {
            using(SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                var par1 = command.Parameters.Add("@storeCodeList", SqlDbType.Structured);
                var par2 = command.Parameters.Add("@productCodeList", SqlDbType.Structured);
                var par3 = command.Parameters.Add("@date1", SqlDbType.Date);
                var par4 = command.Parameters.Add("@date2", SqlDbType.Date);

                par1.TypeName = "t_int_list";
                par1.Value = dt1;

                par2.TypeName = "t_varchar20_list";
                par2.Value = dt2;

                par3.Value = date1;

                par4.Value = date2;

                SqlDataReader reader = await command.ExecuteReaderAsync();
                DataTable dt = new DataTable();

                dt.Load(reader);

                if (dt.Rows.Count > 0)
                    return dt;
                else
                    return null;
            }

        }

        public static void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
