using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Core.CustomEntity.Request
{
    public class InsertBookRequest
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
