using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum RoomStatus
    {
        AVAILABLE = 1,
        BOOKED,
        OCCUPIED
    }

    public class Room
    {
        [DatabaseGenerated ( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public string RoomNumber { get; set; }

        public int FloorNumber { get; set; }

        public RoomStatus Status { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
