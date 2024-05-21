using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionType { get; set; }

        // Navigation property to Order
        public virtual Order Order { get; set; }

        public Transaction()
        {
        }
    }
}