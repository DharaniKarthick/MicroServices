using CustomerService.Model;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustomerService.DatabaseContext
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
           : base(options)
        {
        }
        public DbSet<Customer>? Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }

}
