using System;
using System.ComponentModel.DataAnnotations;

namespace Billingly.Entities.Invoice
{
    public class Customer : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }
    }
}

