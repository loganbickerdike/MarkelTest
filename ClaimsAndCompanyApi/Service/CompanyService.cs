using ClaimsAndCompanyApi.Models;
using ClaimsAndCompanyApi.Service.Repo;

namespace ClaimsAndCompanyApi.Service
{
    public class CompanyService : ICompanyService
    {
        public Company GetCompany(int Id)
        {
            return CompanyRepo.Companies.FirstOrDefault(x => x.Id == Id) ?? new Company();
        }  
    }
}
