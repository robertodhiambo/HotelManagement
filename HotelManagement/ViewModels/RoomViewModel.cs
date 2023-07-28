namespace HotelManagement.ViewModels
{
    public class RoomViewModel
    {
        public int RoomTypeId { get; set; }

        public int AvailableCount { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }

        public string RoomNumber { get; set; }

        public int NoOfGuests { get; set; }
    }

    public class ReserveRoomResult
    {
        public int BookingId { get; set; }

        public bool Status { get; set; }

        public string Message { get; set; }

        public int CustomerId { get; set; }
    }
}
