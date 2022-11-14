using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Billingly.Entities.Application
{
    public class SystemSettings : BaseEntity
    {
        public string? Logo { get; set; }

        [DisplayName("Company Name")]
        [Required]
        public string StoreName { get; set; } = "Billingly";

        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Web { get; set; }

        [Phone]
        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Currency { get; set; }

        [Required]
        public string? Address { get; set; }
    }
}

