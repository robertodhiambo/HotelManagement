namespace HotelManagement.ViewModels
{
    public class CalculatedPriceViewModel
    {
        public string RoomType { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public int NoOfDays { get; set; }

        public string Message { get; set; }

        public string Currency { get; set; }

        public bool Status { get; set; }

        public int RoomTypePricingId { get; set; }
    }
}
