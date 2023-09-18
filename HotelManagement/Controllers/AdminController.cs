using HotelManagement.Models;
using HotelManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly HotelManagementDbContext dbContext;

        public AdminController(HotelManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Register ( )
        {
            return View ( );
        }

        [HttpPost]
        public IActionResult Register ( CustomersViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View ( );
            }

            bool idExists = dbContext.Customers.Where(c => c.IdentificationNo == viewModel.IdentificationNumber).Any();
            if (idExists)
            {
                ModelState.AddModelError ( "IdentificationNumber" , "Customer with Identification Number already exists. Kindly use a different Identification Number." );
                return View ( viewModel);
            }

            bool emailExists = dbContext.Customers.Where(c => c.Email == viewModel.Email).Any();
            if (emailExists)
            {
                ModelState.AddModelError ( "Email" , "Customer with the email address already exists. Kindly use a different email address." );
                return View ( viewModel );
            }

            bool phoneNoExists = dbContext.Customers.Where(c => c.PhoneNumber ==  viewModel.PhoneNumber).Any();
            if (phoneNoExists)
            {
                ModelState.AddModelError ( "PhoneNumber" , "Customer with the phone number already exists. Kindly use a different phone number" );
                return View ( viewModel );
            }

            Customer customer = new Customer
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                IdentificationNo = viewModel.IdentificationNumber,
                DateOfBirth = viewModel.DateOfBirth,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,
                Address = viewModel.Address,
                DateRegistered = DateTime.Now
            };

            dbContext.Customers.Add( customer );
            dbContext.SaveChanges();

            if (customer.Id > 0)
            {
                ModelState.Clear ( );
                viewModel = new CustomersViewModel ( );
                ViewData [ "Success" ] = "Successfully registered admin";
            }

            else
            {
                ViewData [ "Fail" ] = "An error occurred while registering admin";
            }

            return View ( viewModel);
        }
    }
}
