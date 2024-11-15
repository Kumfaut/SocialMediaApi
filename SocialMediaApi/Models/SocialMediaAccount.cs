using System.ComponentModel.DataAnnotations;

namespace SocialMediaApi.Models
{
    public class SocialMediaAccount
    {
        [Key]
        public int SocialMediaAccountId { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string Username { get; set; } 
    }
}
