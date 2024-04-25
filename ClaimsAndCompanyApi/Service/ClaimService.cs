using ClaimsAndCompanyApi.Models;
using ClaimsAndCompanyApi.Service.Repo;


namespace ClaimsAndCompanyApi.Service
{
    public class ClaimService : IClaimService
    { 
        public Claim GetClaim(string UCR)
        {     
            return ClaimRepo.Claims.FirstOrDefault(x => x.UCR == UCR) ?? new Claim();        
        }

        public bool UpdateClaim(Claim updateClaim)
        {
            var claim = ClaimRepo.Claims.Where(x => x.UCR == updateClaim.UCR).FirstOrDefault();

            if (claim is null)
                return false;     
            
            claim.ClaimDate = updateClaim.ClaimDate;
            claim.LossDate = updateClaim.LossDate;
            claim.IncuredLoss = updateClaim.IncuredLoss;
            claim.AssuredName = updateClaim.AssuredName;
            claim.Closed = updateClaim.Closed;

            return true;
        } 
    }
}
