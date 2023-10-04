using CM_API_DAPPER.Dals;
using CM_API_DAPPER.Models;
using CM_API_DAPPER.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CM_API_DAPPER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly BankDal bankDal;
        public BankController()
        {
            bankDal = new BankDal();
        }
        [HttpPost("GetWorkPlacesMas")]
        public ResponseInfo<List<BankModel>> GetWorkPlacesMas(RequestInfo<BankModel> prod)
        {
            ResponseInfo<List<BankModel>> result = new ResponseInfo<List<BankModel>>();
            try
            {
                result = bankDal.GetWorkPlacesMas(prod);
            }
            catch (Exception ex)
            {
                result.errorMessage = ex.Message + ex.StackTrace;
            }

            return result;
        }
    }
}
