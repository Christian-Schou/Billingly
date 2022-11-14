using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Billingly.Entities.Invoice
{
    public class Invoice : BaseEntity
    {
        [Required]
        [DisplayName("Sales Date")]
        public DateTime InvoiceDate { get; set; }

        public string InvoiceCode { get; set; }

        public string Notes { get; set; }

        [Required]
        public Double Total { get; set; }

        public string Status { get; set; }

        public double? Discount { get; set; }

        public double GrandTotal { get; set; }

        [DisplayName("Payment Method")]
        public string PaymentMethod { get; set; }

        [DisplayName("CustomerId")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<InvoiceItem> Items { get; set; }

        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }
    }
}

