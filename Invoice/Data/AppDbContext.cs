using Microsoft.EntityFrameworkCore;
using InvoiceSystem.Models;

namespace InvoiceSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<InvoiceModel> Invoices { get; set; }

      
    }
}
