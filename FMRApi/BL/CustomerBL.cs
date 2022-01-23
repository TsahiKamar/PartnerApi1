//using FMRApi.DAL.BookStoreWebApi.Services;
//using global::FMRApi.DAL;
//using global::FMRApi.Models;

using FMRApi.DataAccess;
using FMRApi.Models;

namespace FMRApi.Bl
    {
    public class CustomerBL
    {
        //private IRepositoryService _repositoryService;

        private AppDbContext _context { get; set; }

        public CustomerBL(AppDbContext context)
        {
            //_repositoryService = repositoryService;
            _context = context;
        }


        public IEnumerable<Customers> GetCustomers() //async Task<
        {

            IEnumerable<Customers> customers;

            try
            {
                //customers = _context.GetCustomers();//await 
                customers = _context.Customers;
                return customers.ToList<Customers>();//BadRequest();//temp

            }
            catch (Exception ex)
            {
                //throw ex;

            }
            return Enumerable.Empty<Customers>();// customers;
            //return customers.ToList<Customers>();//BadRequest();//temp


        }


        //public async dynamic AddCustomer([System.Web.Http.FromBody] Customer request)
        //{


        //    try
        //    {


        //    }
        //    catch (Exception ex)
        //    {

        //        //return NotFound();//temp
        //    }
        //    return null;

        //}



        //public async Customer GetCustomerDetails(string id) // IEnumerable<Customer>
        //{

        //    Customer customer;


        //    try
        //    {


        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    return customer;

        //}

        //public async dynamic UpdateCustomerDetails([System.Web.Http.FromBody] Customer request)
        //{

        //    //var customers;

        //    try
        //    {


        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    return null;

        //}



        public IEnumerable<Products> GetProducts()
        {

            IEnumerable<Products> products;


            try
            {
                //return _context.Products.ToList<Product1>();//customers;
                products = _context.Products;
                return products.ToList<Products>();//BadRequest();//temp

                //var _customerBL = new CustomerBL() ;

                //products = this._IRepositoryService.GetProducts();


                //}
                //catch (Exception ex)
                //{


                //}
                //return products.ToList<Products>();//BadRequest();//temp

                //products = _repositoryService.GetProducts();
                //return products;
            }
            catch (Exception ex)
            {


            }
            return Enumerable.Empty<Products>();
            //return products.ToList<Products>();//BadRequest();//temp

        }




    }
}

//}
