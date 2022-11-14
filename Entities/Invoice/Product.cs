using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Billingly.Entities.Invoice
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("SKU")]
        public string SKU { get; set; }

        [Required]
        public double Price { get; set; }

        public string Description { get; set; }
    }
}

