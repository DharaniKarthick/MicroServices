using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Transactions;
using TransactionService.Model;

namespace TransactionService.DatabaseContext
{
    public class TransactionDBContext:DbContext
    {
        public TransactionDBContext(DbContextOptions<TransactionDBContext> options)
           : base(options)
        {
        }
        public DbSet<TradeTransactions>? TradeTransactions { get; set; }
        public DbSet<TradeStatus>? TransactionStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
