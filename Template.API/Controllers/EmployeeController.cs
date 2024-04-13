using Microsoft.AspNetCore.Mvc;
using Template.bll.Interfaces;
using Template.dal.Interfaces;

namespace Template.API.Controllers
{
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeController(IEmployeeService employeeService, IUnitOfWork unitOfWork)
        {
            this.employeeService = employeeService;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(employeeService.GetAllAsync());
        }

    }
}
