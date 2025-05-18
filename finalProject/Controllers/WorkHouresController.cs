using AutoMapper;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkHouresController : ControllerBase
    {
        private readonly IWorkHouresService _workHouresService;
        private readonly IMapper _mapper;

        public WorkHouresController(IWorkHouresService workHouresService, IMapper mapper)
        {
            _workHouresService = workHouresService;
            _mapper = mapper;
        }
        [Authorize]
        [HttpPost("add-work-day")]
        public async Task<ActionResult<Report>> Post([FromBody] Report report)
        {
            Report res = await _workHouresService.PostReportAsync(report);
            return Ok(_mapper.Map<ReportDTO>(res));
        }

        
    }
}
