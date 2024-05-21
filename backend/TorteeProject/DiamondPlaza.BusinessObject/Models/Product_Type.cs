using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public class ProductType
    {
        [Key] public Guid Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [Required] [Range(0, double.MaxValue)] public decimal Price { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        // Navigation property to Product
        public virtual ICollection<Product> Products { get; set; }

        public ProductType()
        {
            Products = new HashSet<Product>();
        }
    }
}