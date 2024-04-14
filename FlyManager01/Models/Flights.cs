using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace FlyManager01.Models
{
    public class Flights
    {
        public int Id { get; set; }
        [Display(Name = "Date from:")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime FromDate { get; set; }
        [Display(Name = "Time from:")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime FromTime { get; set; }
        [Display(Name = "Date to:")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ToDate { get; set; }
        [Display(Name = "Time to:")]
        [DataType(DataType.Time)]
        [Required]
        public DateTime ToTime { get; set; }
        [Required]
        public string? TypePlane { get; set; }
        [Required]
        public int? NumberPlane { get; set; }
        [Required]
        public string? FromCity { get; set; }
        [Required]
        public string? ToCity { get; set; }
        [Required]
        public string? FirstPilot { get; set; }
        //[Required]
        //public Accounts SecondPilot { get; set; }
        public int? BuisnessClass { get; set; }
        public double? PriceBuisness { get; set; }
        [Required]
        public int? OrdinaryTicket { get; set; }
        [Required]
        public double? Ticket { get; set; }
    }
}
