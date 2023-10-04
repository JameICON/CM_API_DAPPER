using CM_API_DAPPER.Common;
using CM_API_DAPPER.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CM_API_DAPPER.Dals
{
    public class CommonConnection
    {
        private static string connectionString = Global.ConnectionString;
        private static string commonConnectionString = Global.ConnectionString;

        public CommonConnection(UserLogin userLogin)
        {
            SqlConnection connection = new SqlConnection(commonConnectionString);
            connection.Open();
            using (IDbConnection dbConnection = connection)
            {
                try
                {
                    StringBuilder sQuery = new StringBuilder();
                    sQuery.Append(@" select 'Data Source=203.154.157.31;Initial Catalog=NK_panacea;User ID=dev;Password=ic0nte@m' as Dbconnection ");

                    var responseData = dbConnection.Query<UserLogin>(sQuery.ToString(), new {  }).FirstOrDefault(); // fill parameter username password to get db connectionstring
                    connectionString = responseData.Dbconnection;
                    dbConnection.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        internal SqlConnection GetDbConnection()
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
