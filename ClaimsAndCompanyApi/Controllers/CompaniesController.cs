using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ClaimsAndCompanyApi.Dtos;

using ClaimsAndCompanyApi.Service;

namespace ClaimsAndCompanyApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyService companyService ,IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<CompanyDto> GetCompany(int id)
        {    
            var company = _companyService.GetCompany(id);

            if (company.Id == 0)
                return NotFound();      

            return Ok(_mapper.Map<CompanyDto>(company));           
        }
    }
}
