using MeetingServices.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetingServices.DatabaseContext
{
    public class MeetingDBContext : DbContext
    {
        public MeetingDBContext(DbContextOptions<MeetingDBContext> options)
           : base(options)
        {
        }
        public DbSet<Meeting>? Meetings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
