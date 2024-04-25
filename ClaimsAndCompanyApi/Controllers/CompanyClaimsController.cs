using AutoMapper;
using ClaimsAndCompanyApi.Dtos;
using ClaimsAndCompanyApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace ClaimsAndCompanyApi.Controllers
{
    public class CompanyClaimsController : ControllerBase
    {
        private readonly ICompanyClaimsService _companyClaimsService;
        private readonly IMapper _mapper;

        public CompanyClaimsController(ICompanyClaimsService companyClaimsService, IMapper mapper)
        {
           _companyClaimsService = companyClaimsService;
            _mapper = mapper;
        }

        [HttpGet("{companyId}")]
        public ActionResult<IEnumerable<ClaimDto>> GetClaimsByCompanyId(int companyId)
        {
            var claims = _companyClaimsService.GetClaimsByCompanyId(companyId);

            if (!claims.Any())
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<ClaimDto>>(claims));
        }
    }
}
