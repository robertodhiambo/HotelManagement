﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum PaymentMethod
    {
        Cash = 1,
        MPESA = 2
    }

    public class Payment
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int CustomerId { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Amount { get; set; }

        public string Reference { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("BookingId")]
        public virtual Booking Booking { get; set; }
    }
}