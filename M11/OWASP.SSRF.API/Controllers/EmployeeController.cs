using Microsoft.AspNetCore.Mvc;
using OWASP.SSRF.API.Data;

namespace OWASP.SSRF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("Employees")]
        public async Task<IActionResult> Employees()
        {
            var data = new EmployeeData();

            return Ok(data.GetAllEmployees());
        }
    }
}