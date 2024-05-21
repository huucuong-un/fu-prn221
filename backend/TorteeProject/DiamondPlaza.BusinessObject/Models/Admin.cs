using System;
using System.Collections.Generic;

namespace DiamondPlaze.BusinessObject.Models
{
    public partial class Admin
    {
        public Admin()
        {

        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Telephone { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? AccountId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? Code { get; set; }
        public string? Address { get; set; }

        public virtual Account? Account { get; set; }

    }
}
