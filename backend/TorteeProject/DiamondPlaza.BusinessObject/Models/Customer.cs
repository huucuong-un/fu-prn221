using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class Customer
    {
        public Customer()
        {
            // Initialize default values if necessary.
            IsDelete = false;
            CreateDate = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }
        

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string Description { get; set; }
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Income { get; set; }

        public bool IsDelete { get; set; }

        public Guid? AccountId { get; set; }

        public Guid TransactionId { get; set; }

        public int Point { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(20, ErrorMessage = "Code cannot be longer than 20 characters")]
        public string Code { get; set; }

        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters")]
        public string Address { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(200, ErrorMessage = "Email cannot be longer than 200 characters")]
        public string Mail { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(20, ErrorMessage = "Phone number cannot be longer than 20 characters")]
        public string Phone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

        // Navigation properties
        public virtual Account Account { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}