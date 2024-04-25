namespace ClaimsAndCompanyApi.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }       
        public DateTime EndDate { get; set; }

    }
}
