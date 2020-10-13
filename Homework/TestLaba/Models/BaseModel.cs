using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace TestLaba.Models
{
    public class BaseModel
    {
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public bool IsEdit { get; set; } = false;
        public DateTime? DateLastEdited { get; set; }
    }
}