namespace ClaimsAndCompanyApi.Models
{
    public class Claim
    {
        public string UCR { get; set; }
        public Company Company { get; set; }
        public DateTime ClaimDate { get; set; }
        public DateTime LossDate { get; set; }
        public string AssuredName { get; set; }
        public decimal IncuredLoss { get; set; }
        public bool Closed { get; set; }
        public ClaimType ClaimType { get; set; }
    }

    public enum ClaimType
    {
        Industrial,
        Natural,
        Building,
        Liability,
        Shipping

    }
}
