using ClaimsAndCompanyApi.Models;
using ClaimsAndCompanyApi.Service.Repo;

namespace ClaimsAndCompanyApi.Service
{
    public class CompanyClaimsService : ICompanyClaimsService
    {
        public IEnumerable<Claim> GetClaimsByCompanyId(int id)
        {
            return ClaimRepo.Claims.Where(x => x.Company.Id == id);
        }        
    }
}
