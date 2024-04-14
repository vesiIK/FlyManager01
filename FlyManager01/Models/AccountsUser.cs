using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FlyManager01.Models
{
    public class AccountsUser : IdentityUser
    {
        [Required]
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? NickName { get; set; }
        public string? EGN { get; set; }
        public string? Role { get; set; }
        public string? Adress { get; set; }
    }
}
