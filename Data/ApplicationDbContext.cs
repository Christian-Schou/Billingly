using Billingly.Entities.Invoice;
using Billingly.Entities.Application;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Billingly.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<SystemSettings> SystemSettings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
}

