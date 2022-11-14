using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Billingly.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}

