using HotelManagement.Models;

namespace HotelManagement.ViewModels
{
    public class PaymentViewModel
    {
        public PaymentMethod PaymentMethod { get; set; }

        public string PaymentMethodStr { get; set; }

        public decimal Amount { get; set; }

        public decimal TotalPaid { get; set; }

        public decimal PendingAmount { get; set; }

        public string Reference { get; set; }
    }
}
