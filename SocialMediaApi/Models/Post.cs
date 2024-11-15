using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SocialMediaApi.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int SocialMediaAccountId { get; set; } // Can remain as an identifier but not enforced as a foreign key
    }
}