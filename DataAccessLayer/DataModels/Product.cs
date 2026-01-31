using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModels
{
        public class Product
        {
            [Key]
            public int ProductId { get; set; }

            [Required]
            public string Name { get; set; } = string.Empty;

            [Column(TypeName = "decimal(10,2)")]
            public decimal Price { get; set; }
        }
    
}
