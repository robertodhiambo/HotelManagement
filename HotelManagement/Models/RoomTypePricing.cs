using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum PricingStatus
    {
        INACTIVE = 1,
        ACTIVE
    }

    public class RoomTypePricing
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public int RoomTypeId { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }

        public PricingStatus Status { get; set; }

        public DateTime DateCreated { get; set; }

        [ForeignKey( "RoomTypeId" )]
        public virtual  RoomType RoomType { get; set; }
    }
}
