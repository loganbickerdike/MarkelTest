namespace ClaimsAndCompanyApi.Bl
{
    public class ClaimBusinessLogic
    {
        public int GetDaysOld(DateTime claimDate, DateTime now)
        {
            return -(claimDate - now).Days;
        }
    }
}
