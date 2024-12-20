using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstRelation.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } //Primary key

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<Post> Posts { get; set; } //To keep the user's posts
    }
}