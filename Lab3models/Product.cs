
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3, ErrorMessage = "Name must be greater than 3 char")]
        public string Name { get; set; }

        [Required]
        [Range(200, 700)]
        public int Price { get; set; }

        [Required]
     
        public string Image { get; set; }

        [ForeignKey("Category")]
        public int Cat_Id { get; set; }

        public virtual Category? Category { get; set; }
    }
}
