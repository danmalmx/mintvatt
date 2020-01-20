using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mintvattAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DefaultValue("Email")]
        public string UserName { get; set; } 
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }

    }
}
