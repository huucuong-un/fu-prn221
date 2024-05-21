using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public class Wages
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public Wages() { }
    }
}