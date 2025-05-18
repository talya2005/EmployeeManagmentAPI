using AutoMapper;
using EmployeeManagement.Core.DTO;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeesService _employeesService;
        private readonly IMapper _mapper;
        

        public EmployeesController(IEmployeesService employeesService, IMapper mapper)
        {
            _employeesService = employeesService;
            _mapper = mapper;
        }

        [Authorize(Roles = "Manager")] 
        [HttpPost("add-employee")]
        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            await _employeesService.PostEmployeeAsync(employee);
            return Ok("Employee added successfully");
        }
        [Authorize]
        [HttpPut("update-employee")]
        public async Task<ActionResult<Employee>> Put([FromBody] Employee employee)
        {
            Employee res = await _employeesService.PutEmployeeAsync(employee);
            return Ok(_mapper.Map<EmployeeDTO>(res));
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> Delete(string id)
        {
            return Ok(await _employeesService.DeleteEmployeeAsync(id));
        }
    }
}
