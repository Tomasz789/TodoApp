using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.WebApp.Models
{
    public class NewUser
    {
        [Required]
        [MaxLength(50, ErrorMessage ="User name must be max 50 characters length.")]
        [MinLength(6, ErrorMessage ="User name must be 6 characters at least.")]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password should have 8 characters.")]
        public string Password { get; set; }

        [Required]
        public string ConfirmedPassword { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
