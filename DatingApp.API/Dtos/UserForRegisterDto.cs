using System.ComponentModel.DataAnnotations;
using System;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
       public string Username { get; set; }
       [Required]
       [StringLength(8, MinimumLength = 4, ErrorMessage = "You must spesify password between 4 and 8 char")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string knownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string NativeLanguage { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

         UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}