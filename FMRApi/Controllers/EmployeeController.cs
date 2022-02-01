using LEUMITApi.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace LEUMITApi.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly ILogger<EmployeeController> _logger;
         

        public EmployeeController(ILogger<EmployeeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

            if (!_context.Employees.Any())
            {
                this._EMPLOYEES.ForEach(s => _context.Employees.Add(s));
                _context.SaveChanges();
            }
        }

        private List<Employees> _EMPLOYEES = new List<Employees>
        {
            new Employees { id = "1",fullName = "Omri",phone="0523555666",email="omry89@gmail.com",salary = 34000 },
            new Employees { id = "2",fullName = "Bela",phone="0523555342",email="bela@gmail.com",salary = 12000 },
            new Employees { id = "3",fullName = "Sharon",phone="0543555342",email="sharon@gmail.com",salary = 27000 }

        };

 

        [HttpGet("employees")] 
        public ActionResult<IEnumerable<Employees>> GetEmployees() 
        {

            IEnumerable<Employees> employees = Enumerable.Empty<Employees>(); 
            try 
            {
                employees = _context.Employees;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error,ex.ToString(),null);
                return StatusCode(500);
            }

            return employees.ToList<Employees>();

        }

        [HttpPut("updateEmployeeDetails")]
        public IActionResult UpdateEmployeeDetails(Employees request)
        {
            try
            {
                _context.Employees.Update(request);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(request);
        }



        [HttpPost("calcTotalSalaries")]
        public IActionResult CalcTotalSalaries(Employees[] request)
        {
            var totalSalaries = 0;
            try
            {
                foreach (Employees employee in request)
                {
                    totalSalaries += employee.salary;
                }
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(totalSalaries);
        }




    }
}