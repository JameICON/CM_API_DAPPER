using CM_API_DAPPER.Common;
using CM_API_DAPPER.Models;
using System.Data.SqlClient;

namespace CM_API_DAPPER.Dals
{
    public class BaseConnection
    {
        private static string connectionString = Global.ConnectionString;

        protected SqlConnection GetOpenConnection(string ConnName = null)
        {
            SqlConnection connection = null;
            if (!string.IsNullOrEmpty(connectionString))
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }

            return connection;
        }
    }
}
