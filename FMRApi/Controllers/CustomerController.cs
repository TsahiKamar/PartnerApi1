using FMRApi.DAL;
using FMRApi.DataAccess;
using FMRApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace FMRApi.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly ILogger<CustomerController> _logger;
         

        public CustomerController(ILogger<CustomerController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

            if (!_context.Customers.Any())
            {
                this._CUSTOMERS.ForEach(s => _context.Customers.Add(s));
                _context.SaveChanges();
            }
            if (!_context.Products.Any())
            {

                this._PRODUCTS.ForEach(s => _context.Products.Add(s));
                _context.SaveChanges();
            }
        }

        private List<Customers> _CUSTOMERS = new List<Customers>
        {
            new Customers { customerId = "1",fullName = "Omri",phones = new List<Phone>() {new Phone {customerId = "1",type = "נייד", phoneNumber = "0523610026" }} ,products = new List<Product>() {new Product { customerId = "1",productId = 122,name = "Gemel1",description="Gemel 40+", interestPercents=5,deposit=20000,date=new DateTime() } },addresses = new List<Address>() {new Address { customerId = "1",type = "בית",city = "Jerusalem",street="Yaffo",houseNum = 100,pob= 32564,zip=11111} } },
            new Customers { customerId = "2",fullName = "bela",phones = null,products = null,addresses = null }
        };

        private List<Products> _PRODUCTS = new List<Products>
        {
            new Products {  customerId = "1",productId = 1,name="PRODCT 1",description="desc",interestPercents=2, deposit=3000, date = new DateTime() },
            new Products {  customerId = "2",productId = 2,name="PRODCT 2",description="desc",interestPercents=3, deposit=5000, date = new DateTime() },

        };


        [HttpGet("customers")] 
        public ActionResult<IEnumerable<Customers>> GetCustomers() 
        {

            IEnumerable<Customers> customers  = Enumerable.Empty<Customers>(); 
            try 
            { 
                 customers = _context.Customers;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error,ex.ToString(),null);
                return StatusCode(500);
            }

            return customers.ToList<Customers>();

        }

        [HttpGet("products")]
        public ActionResult<IEnumerable<Products>> GetProducts(string? customerId)
        {

            IEnumerable<Products> products = Enumerable.Empty<Products>();

            try
            {
                 products = !string.IsNullOrEmpty(customerId) && customerId != "undefined" ? _context.Products.Where(x=> x.customerId == customerId) : _context.Products;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);

            }
            return products.ToList<Products>();

        }


        [HttpGet("GetCustomerDetails")]
        public IActionResult GetCustomerDetails(string id)
        {
            dynamic customer;     
            
            try 
            { 
                //tbc
                customer = _context.Customers.Where(x => x.id == id).FirstOrDefault(); //|| x.products.Find(z => z.customerId == x.customerId

                if (customer == null) return NotFound();

                //var products = _context.Products.Where(x => x.id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
               _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(customer);
        }

        [HttpPost(Name = "addCustomer")]
        public IActionResult AddCustomer(Customers request)
        {
            try
            {
                _context.Customers.Add(request);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString(), null);
                return StatusCode(500);
            }
            return Ok(request);
        }

        
        [HttpPut(Name = "updateCustomerDetails")]
        public IActionResult UpdateCustomerDetails(Customers request)
        {
            try
            {
                _context.Customers.Update(request);
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