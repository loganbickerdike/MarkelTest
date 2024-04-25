using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Service
{
    public interface ICompanyClaimsService
    {
        public IEnumerable<Claim> GetClaimsByCompanyId(int id);
    }
}
