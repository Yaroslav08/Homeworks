using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace TestLaba.Models
{
    public class Post : BaseModel
    {
        [Key]
        public long Id { get; set; }
        [Required, MinLength(1), MaxLength(5000)]
        public string Text { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}