using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Service
{
    public interface ICompanyService
    {
        Company GetCompany(int Id);
    }
}
