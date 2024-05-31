using Microsoft.EntityFrameworkCore;
using SupplierServices.Model;
using System.Collections.Generic;

namespace SupplierServices.DatabaseContext
{
    public class SupplierDBContext : DbContext
    {
        public SupplierDBContext(DbContextOptions<SupplierDBContext> options)
           : base(options)
        {
        }
        public DbSet<Supplier>? Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
