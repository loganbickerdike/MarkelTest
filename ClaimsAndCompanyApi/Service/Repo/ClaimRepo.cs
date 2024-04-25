using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Service.Repo
{
    public static class ClaimRepo
    {

        public static List<Claim> Claims; 

        static ClaimRepo()
        {
            Claims = Get();
        }

        private static List<Claim> Get()
        {   
            return new List<Claim>
            {
                new Claim
                {
                    UCR = "A1",
                    Company = new Company{ Id = 1},
                    ClaimDate = new DateTime(2024,1,15),
                    LossDate = new DateTime(2024,1,14),
                    AssuredName = "Company x",
                    IncuredLoss = 5000,
                    Closed = false,
                    ClaimType = ClaimType.Industrial
                },
                 new Claim
                {
                    UCR = "A11",
                    Company = new Company{ Id = 1},
                    ClaimDate = new DateTime(2024,1,15),
                    LossDate = new DateTime(2024,1,14),
                    AssuredName = "Company XX",
                    IncuredLoss = 10000,
                    Closed = false,
                    ClaimType = ClaimType.Industrial
                },
                new Claim
                {
                    UCR = "B1",
                    Company = new Company{ Id = 2},
                    ClaimDate = new DateTime(2023,1,11),
                    LossDate = new DateTime(2023,1,1),
                    AssuredName = "Company x",
                    IncuredLoss = 6586254,
                    Closed = false,
                    ClaimType = ClaimType.Industrial
                },
                new Claim
                {
                    UCR = "C1",
                    Company = new Company{ Id = 3},
                    ClaimDate = new DateTime(2022,1,11),
                    LossDate = new DateTime(2022,1,10),
                    AssuredName = "Company x",
                    IncuredLoss = 56841,
                    Closed = false,
                    ClaimType = ClaimType.Industrial
                },
                new Claim
                {
                    UCR = "D1",
                    Company = new Company{ Id = 4},
                    ClaimDate = new DateTime(2024,1,1),
                    LossDate = new DateTime(2023,12,1),
                    AssuredName = "Company x",
                    IncuredLoss = 22556,
                    Closed = false,
                    ClaimType = ClaimType.Industrial
                },
            };            
        }
    }
}
