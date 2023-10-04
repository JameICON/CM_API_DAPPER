namespace CM_API_DAPPER.Models
{
    public class RequestInfo<T> where T : class
    {
        public string mode { get; set; }
        public string user { get; set; }
        public string ip { get; set; }
        public string lang { get; set; }
        public string branch_id { get; set; }
        public T requestData { get; set; }
        public string barcode { get; set; }
        public UserLogin UserLogin { get; set; }
    }
}
