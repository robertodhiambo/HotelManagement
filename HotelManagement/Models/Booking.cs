using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum BookingStatus
    {
        PENDING_PAYMENT = 1,
        PARTIALLY_PAID,
        FULLY_PAID,
        CHECKED_IN,
        CHECKED_OUT
    }

    public class Booking
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int RoomId { get; set; }

        public int PaymentId { get; set; }

        public int NoOfGuests { get; set; }

        public DateTime DateBooked { get; set; }

        public decimal TotalCost { get; set; }

        public decimal AmountPaid { get; set; }

        public int NoOfDays { get; set; }

        public BookingStatus Status { get; set; }

        public DateTime ExpectedCheckInDate { get; set; }

        public DateTime ExpectedCheckOutDate { get; set; }

        public DateTime? ActualCheckInDate { get; set; }

        public DateTime? ActualCheckOutDate { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
    }
}
