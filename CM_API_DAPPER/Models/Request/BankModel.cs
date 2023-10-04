namespace CM_API_DAPPER.Models.Request
{
    public class BankModel
    {
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public string? Country { get; set; }

        public string? CompanyCode { get; set; }
        public string? Active { get; set; } = "Y";
        public string? User { get; set; }
        public string? Module { get; set; }

    }
}
