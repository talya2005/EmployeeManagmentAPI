using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Services;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        private readonly AuthenticationService _authenticationService;

        public AuthController(IEmployeesService employeesService, AuthenticationService authenticationService)
        {
            _employeesService = employeesService;
            _authenticationService = authenticationService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var employee = await _employeesService.GetEmployeeByUsernameAsync(model.UserName);
            if (employee != null && employee.Password == model.Password)
            {
                var token = _authenticationService.GenerateJwtToken(employee);
                return Ok(new { Token = token });
            }

            return Unauthorized();  
        }

    }
}
