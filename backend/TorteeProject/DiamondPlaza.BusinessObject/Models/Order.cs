using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }
        
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        
        // Navigation property
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}