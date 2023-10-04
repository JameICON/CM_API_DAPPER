namespace CM_API_DAPPER.Models
{
    public class ResponseInfo<T> where T : class
    {
        public bool isSuccess { get; set; } = false;
        public string errorCode { get; set; } = "99";
        public string errorKey { get; set; } = "";
        public string errorMessage { get; set; } = "";
        public int errorIndex { get; set; } = 0;
        public T responseData { get; set; }
        public string returnData { get; set; }
    }
}
