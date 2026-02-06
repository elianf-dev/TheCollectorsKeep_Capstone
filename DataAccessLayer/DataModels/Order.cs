using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModels
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [Required]
        public String CustomerID { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerID))]
        public ApplicationUser Customer { get; set; }

        [Required]
        public DateTime DateOrdered { get; set; } = DateTime.UtcNow;

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        [Required]
        [StringLength(100)]
        public string ShippingStreet { get; set; }

        [Required]
        [StringLength(50)]
        public string ShippingCity { get; set; }

        [Required]
        [StringLength(2)]
        public string ShippingState { get; set; }

        [Required]
        [StringLength(10)]
        public string ShippingZipCode { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}