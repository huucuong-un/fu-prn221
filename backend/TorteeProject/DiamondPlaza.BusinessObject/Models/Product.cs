﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Weight { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public Product()
        {
        }
    }
}
