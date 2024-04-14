using System.ComponentModel.DataAnnotations;

namespace FlyManager01.Models
{
    public class Works
    {
        public int? Id { get; set; }
        [Required]
        public string? Job { get; set; }
    }
}
