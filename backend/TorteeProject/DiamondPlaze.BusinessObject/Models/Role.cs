using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        [Key]
        public Guid Id { get; set; }

        public string RoleName { get; set; }

        public bool IsDelete { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}