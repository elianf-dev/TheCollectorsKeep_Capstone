using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.DataModels;


namespace DataAccessLayer.Data
{
    public class CollectorsKeepDbContext : DbContext
    {
        public CollectorsKeepDbContext(DbContextOptions<CollectorsKeepDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
