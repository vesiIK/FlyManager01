﻿using System.ComponentModel.DataAnnotations;

namespace FlyManager01.ViewModals
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }
}
