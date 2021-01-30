using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Library.Entities
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [StringLength(100)]
        public string BookName { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(100)]
        public double Price { get; set; }

    }
}
