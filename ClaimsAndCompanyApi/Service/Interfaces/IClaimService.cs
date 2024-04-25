using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Service
{
    public interface IClaimService
    {
        public Claim GetClaim(string UCR);
        bool UpdateClaim(Claim upDateclaim);
    }
}
