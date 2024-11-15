using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SocialMediaApi.Models
{
    public class User
    {

        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}

