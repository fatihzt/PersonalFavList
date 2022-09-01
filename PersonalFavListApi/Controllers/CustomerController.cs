using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PFL.Business.Abstract;
using PFL.Business.Request.Customer;
using PFL.Core.Authentication;
using PFL.Entities;

namespace PersonalFavListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //private readonly Customer _customer;
        //public CustomerController(Customer customer)
        //{
        //    _customer = customer;
        //}
        //public static Customer _customer = new Customer();
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
       
        [HttpPost("Register")]
        public IActionResult Register(CustomerCreateRequest request)
        {
            
            CustomerAuth.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            Customer entity = new() { Name = request.Name,Age=request.Age,TelNo=request.TelNo,Country=request.Country,Gender=request.Gender,PasswordHash=passwordHash,PasswordSalt=passwordSalt };
            if (request.Name == entity.Name) return BadRequest("Customer Name is already taken!");
            int result = _customerService.Add(entity);
            return Ok(result > 0 ? "Success" : "Error");
            

        }
        [HttpPost("Login")]
        public IActionResult Login(CustomerCreateRequest request)
        {
            Customer entity = new(){Name=request.Name };
            if (entity.Name != request.Name)
            {
                return BadRequest("User not found!");
            }
            return Ok("Success");
        }
    }
}
