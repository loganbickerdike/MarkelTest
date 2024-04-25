using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Dtos
{
    public class ClaimDto
    {
        public string UCR { get; set; }
        public int CompanyId { get; set; }
        public DateTime ClaimDate { get; set; }
        public DateTime LossDate { get; set; }
        public string AssuredName { get; set; }
        public decimal IncuredLoss { get; set; }
        public bool Closed { get; set; }
        public string ClaimType { get; set; }
        public int ClaimDaysOld { get; set; }

    }
}
