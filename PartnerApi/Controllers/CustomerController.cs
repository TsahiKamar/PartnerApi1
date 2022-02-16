using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PartnerApi.Entities;

namespace Api.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerBL _customerBL;

        public CustomerController(ILogger<CustomerController> logger,ICustomerBL customerBL)
        {
            _logger = logger;
            _customerBL = customerBL;

            if (!_CUSTOMERS.Any())
            {
                _CUSTOMERS = _customerBL.LoadJson();
            }
 
        }

    
        private List<Customer> _CUSTOMERS = new List<Customer> 
        {
      
        };

        [HttpGet("customers")] 
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {

            IEnumerable<Customer> customers  = Enumerable.Empty<Customer>();  
            try 
            {
                customers = _CUSTOMERS;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error,ex.ToString(),null);
                return StatusCode(500);
            }

            return Ok(customers);

        }

      


        [HttpGet("GetCustomerDetails")]
        public IActionResult GetCustomerDetails(string id)
        {
            dynamic customer;     
            
            try 
            { 
                customer = _CUSTOMERS.Where(x => x.customerId == id).FirstOrDefault();

                if (customer == null) return NotFound();

            }
            catch (Exception ex)
            {
               _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(customer);
        }

 
        
        [HttpPut("updateCustomerDetails")]
        public IActionResult UpdateCustomerDetails(Customer request)
        {
            try
            {
                var customer = _CUSTOMERS.Single(x => x.customerId == request.customerId);
                customer.address = request.address;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(request);
        }





    }
}