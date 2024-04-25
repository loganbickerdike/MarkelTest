using AutoMapper;
using ClaimsAndCompanyApi.Dtos;
using ClaimsAndCompanyApi.Models;
using ClaimsAndCompanyApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace ClaimsAndCompanyApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimService _claimService;
        private readonly IMapper _mapper;

        public ClaimsController(IClaimService claimService, IMapper mapper)
        {
            _claimService = claimService;
            _mapper = mapper;
        }

        [HttpGet("{UCR}")]
        public ActionResult<ClaimDto> GetClaim(string UCR)
        {
            var claim = _claimService.GetClaim(UCR);

            if (String.IsNullOrEmpty(claim.UCR))
                return NotFound();

            return Ok(_mapper.Map<ClaimDto>(claim));
        }

        [HttpPut]
        public ActionResult UpdateClaim(ClaimDtoUpdate claim) 
        {
            if(_claimService.UpdateClaim(_mapper.Map<Claim>(claim)))
                return Ok(); 
            else
                return NotFound();

        }    

    }
}
