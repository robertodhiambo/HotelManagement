using System.ComponentModel.DataAnnotations;

namespace HotelManagement.ViewModels
{
    public class CustomersViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required,StringLength(30)]
        public string LastName  { get; set; }

        [Required,StringLength(30)]
        public string IdentificationNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required,StringLength(20)]
        [EmailAddress]
        public string Email { get; set; }

        [Required,StringLength(15)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }

    public class RegisterCustomerResult
    {
        public int CustomerId { get; set; }

        public string Message { get; set; }

        public bool Status { get; set; }
    }
}
