using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework.Constraints;
using PolcarZadanie.DbServices;
using PolcarZadanie.Dtos;
using PolcarZadanie.Models;
using System.Text;

namespace PolcarZadanie.Controllers
{
    [Route("/api/employees")]
    [ApiController]
    //[Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeesDbService _dbService;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesDbService service)
        {
            _logger = logger;
            _dbService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            return Ok(await _dbService.GetAllEmployees());
        }

        [HttpGet("id={empId}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(long empId)
        {
            var emp = await _dbService.GetEmployeeById(empId);
            return emp == null ? NotFound() : Ok(emp);
        }

        [HttpGet("email={emailB}")]
        public async Task<ActionResult<Employee>> GetEmployeeByEmail(string emailB)
        {
            if (emailB == null || emailB == string.Empty)
                return BadRequest("Please provide an email address in the request body.");
            string actualEmail = Encoding.UTF8.GetString(Convert.FromBase64String(emailB + "=="));
            var emp = await _dbService.GetEmployeeByEmail(actualEmail);
            return emp == null ? NotFound() : Ok(emp);
        }
    }
}
