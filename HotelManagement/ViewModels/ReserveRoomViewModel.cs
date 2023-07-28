using System.Security.Principal;

namespace HotelManagement.ViewModels
{
    public class ReserveRoomViewModel
    {
        public int NoOfGuests { get; set; }

        public decimal TotalCost { get; set; }

        public string RoomType { get; set; }

        public string RoomNumber { get; set; }

        public int RoomPricingId { get; set; }

        public int NoOfDyas { get; set; }

        public RoomViewModel Room { get; set; }

        public List<RoomViewModel> AvailableRooms  { get; set; }

        public DateTime ExpectedCheckInDate { get; set; }

        public DateTime ExpectedCheckOutDate { get; set ; }

        public CustomersViewModel Customer { get; set; }

        public PaymentViewModel Payment { get; set; }
    }

    public class ReserveRoomResults
    {
        public int BookingId { get; set; }

        public bool Status { get; set; }

        public string   Message { get; set; }

        public int CustomerId { get; set; }
    }
}
