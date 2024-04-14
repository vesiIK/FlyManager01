using System.ComponentModel.DataAnnotations;

namespace FlyManager01.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? EGN { get; set; }
        [Required]
        public string? TypeTicket { get; set; }
        [Required]
        public string? Country { get; set; }
        public string? TelephoneNummer { get; set; }
        public Reservations? PersonAddmin { get; set; }
    }
}
