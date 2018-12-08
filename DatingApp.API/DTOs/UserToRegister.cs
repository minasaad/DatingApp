using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserToRegisterDTO
    {
 [Required]
        public string username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Error Yasta")]
        public string password { get; set; }
    }
}