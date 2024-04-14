using System.ComponentModel.DataAnnotations;

namespace FlyManager01.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
