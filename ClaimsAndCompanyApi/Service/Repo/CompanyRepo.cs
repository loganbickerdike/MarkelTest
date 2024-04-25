using ClaimsAndCompanyApi.Models;
using Microsoft.AspNetCore.SignalR;

namespace ClaimsAndCompanyApi.Service.Repo
{
    public static class CompanyRepo
    {
        public static List<Company> Companies { get; set; }

        static CompanyRepo()
        {
            Companies = Get();
        }

        private static List<Company> Get()        
        {
            return new List<Company>
            {
                new Company
                {
                    Id = 1,
                    Name = "Global Industries",
                    Address1 = "1 Bond Street",
                    Address2 =  "London",
                    PostCode = "LS1 5RP",
                    Country = "United Kingdom",
                    EndDate = new DateTime(2023,1,1),
                },

                 new Company
                {
                    Id = 2,
                    Name = "Shell",
                    Address1 = "1 Baker Street",
                    Address2 =  "London",
                    PostCode = "LS1 5RP",
                    EndDate = new DateTime(2024,1,1),
                },

                 new Company
                {
                    Id = 3,
                    Name = "Tesco",
                    Address1 = "Club Card Street",
                    Address2 =  "York",
                    PostCode = "YK3 5RP",
                    EndDate = new DateTime(2025,1,1),
                },
                new Company
                {
                    Id = 4,
                    Name = "HSBC",
                    Address1 = "Gold Street",
                    Address2 =  "London",
                    PostCode = "LS1 3RP",
                    EndDate = new DateTime(2026,1,1),
                },
                 new Company
                {
                    Id = 5,
                    Name = "GlaxoSmithKline",
                    Address1 = "Pharm Street",
                    Address2 =  "London",
                    PostCode = "LS3 3RP",
                    EndDate = new DateTime(2027,1,1),
                },

            };
        }
    }
}
