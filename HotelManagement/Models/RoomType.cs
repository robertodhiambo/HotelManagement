using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum RoomTypes
    {
        Single = 1,
        Standard = 2,
        Executive = 3
    }

    public class RoomType
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RoomId { get; set; }

        public int RoomTypePricingId { get; set; }

        [ForeignKey( "RoomId" )]
        public virtual Room Room { get; set; }

        [ForeignKey( "RoomTypePricingId" )]
        public virtual RoomTypePricing RoomTypePricing { get; set; }
    }
}
