using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace TestLaba.Models
{
    public class User : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(25)]
        public string Username { get; set; }
        [Required, MinLength(5), MaxLength(50)]
        public string Fullname { get; set; }
        public List<Post> Posts { get; set; }
    }
}