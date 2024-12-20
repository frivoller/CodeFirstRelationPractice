using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstRelation.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } //Primary key

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } //Each post belongs to a user
    }
}