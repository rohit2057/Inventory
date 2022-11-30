using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using intentory.Models;

namespace intentory.data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Inventory> inventories { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Customer> customers { get; set; }
        
    }
}
