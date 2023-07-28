using System.ComponentModel.DataAnnotations;

namespace HotelManagement.ViewModels
{
    public class RoomTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

    }
}
