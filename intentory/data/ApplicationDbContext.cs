using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using intentory.Models;

namespace intentory.data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ProductGroup> groups { get; set; }
        public DbSet<Measure> measures { get; set; }
        public DbSet<ProductAdd> products { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<ProductPurchase> purchases { get; set; }

    }
}
