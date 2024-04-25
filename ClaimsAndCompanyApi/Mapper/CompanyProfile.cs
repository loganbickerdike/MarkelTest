using ClaimsAndCompanyApi.Dtos;
using ClaimsAndCompanyApi.Models;
using AutoMapper;

namespace ClaimsAndCompanyApi.Mapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(x => x.Active, opt => opt.MapFrom(x => x.EndDate >= DateTime.Now));

        }
    }
}
