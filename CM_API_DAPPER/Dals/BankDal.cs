using CM_API_DAPPER.Models;
using CM_API_DAPPER.Models.Request;
using Dapper;
using System.Data;
using System.Text;

namespace CM_API_DAPPER.Dals
{
    public class BankDal
    {
        public ResponseInfo<List<BankModel>> GetWorkPlacesMas(RequestInfo<BankModel> prod)
        {
            ResponseInfo<List<BankModel>> result = new ResponseInfo<List<BankModel>>();
            var dbconnection = new CommonConnection(prod.UserLogin);
            using (IDbConnection dbConnection = dbconnection.GetDbConnection())
            {
                try
                {
                    StringBuilder sQuery = new StringBuilder();
                    sQuery.Append(" select WP.WorkId as BankCode,  ");
                    sQuery.Append("    concat(WP.Mapping1,' - ',WP.Name) as BankName,WP.StockPlaceId as Country,WP.PlaceType as CompanyCode ");
                    sQuery.Append(" from TBM_WORK_PLACES WP WITH (NOLOCK) ");
                    sQuery.Append(" where WP.CancelFlag is null ");

                    result.responseData = dbConnection.Query<BankModel>(sQuery.ToString()).ToList();
                    result.isSuccess = true;
                    result.errorCode = "00";
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    result.errorMessage = ex.Message + ex.StackTrace;
                }
            }

            return result;
        }
    }
}
