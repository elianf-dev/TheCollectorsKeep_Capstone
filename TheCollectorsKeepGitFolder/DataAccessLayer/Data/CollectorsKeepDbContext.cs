using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Data
{
    public class CollectorsKeepDbContext : IdentityDbContext
    {
        public CollectorsKeepDbContext(DbContextOptions<CollectorsKeepDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                   .Property(p => p.Price)
                   .HasPrecision(18, 2); // ✅ standard money precision
        }
    }
}
