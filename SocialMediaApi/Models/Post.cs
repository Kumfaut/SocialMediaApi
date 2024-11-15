using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SocialMediaApi.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        [StringLength(100)]
        public string Content { get; set; }

        public DateTime Timestamp { get; set; }

        public int SocialMediaAccountId { get; set; } 
    }
}