using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class Customer
    {
        public Customer()
        {
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string Description { get; set; }

        public bool IsDelete { get; set; }

        public Guid? AccountId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

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

        public virtual Account Account { get; set; }
    }
}