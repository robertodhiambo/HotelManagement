using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class Customer
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public int BookingId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentificationNo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime DateRegistered { get; set; }

        [ForeignKey("BookingId")]
        public virtual  Booking Booking { get; set; }
    }
}
