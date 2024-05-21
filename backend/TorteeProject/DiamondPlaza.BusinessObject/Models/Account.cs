using System;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class Account
    {
        public Account()
        {
            // Initialize default values if necessary.
            IsDelete = false;
            CreateDate = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }

        public Guid? RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        public bool? IsDelete { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        public Guid? CounterID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        

        // Navigation properties
        public virtual Role Role { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Counter? Counter { get; set; }
    }
}