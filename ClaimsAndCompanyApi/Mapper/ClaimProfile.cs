using AutoMapper;
using ClaimsAndCompanyApi.Bl;
using ClaimsAndCompanyApi.Dtos;
using ClaimsAndCompanyApi.Models;

namespace ClaimsAndCompanyApi.Mapper
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            CreateMap<Claim, ClaimDto>()
           .ForMember(x => x.CompanyId, opt => opt.MapFrom(x => x.Company.Id))
           .ForMember(x => x.ClaimType, opt => opt.MapFrom(x => x.ClaimType.ToString()))     
           .ForMember(x => x.ClaimDaysOld, opt => opt.MapFrom(x => new ClaimBusinessLogic().GetDaysOld(x.ClaimDate, DateTime.Now))); 
            CreateMap<ClaimDtoUpdate, Claim>();
        }
    }
}
