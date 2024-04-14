using FlyManager01.Models;
using System.ComponentModel.DataAnnotations;

namespace FlyManager01.ViewModals
{
    public class RegistrtionVM
    {
        //public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Nickname is required")]
        public string? NickName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Passwort is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Password don't match")]
        [Display(Name = "Conform Password")]
        public string? ConformPassword { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "EGN is required")]
        public string? EGN { get; set; }
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone nummber is required")]
        public string? PhoneNumber { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Address is required")]
        public string? Adress { get; set; }
        public Works? Job { get; set; }

    }
}
