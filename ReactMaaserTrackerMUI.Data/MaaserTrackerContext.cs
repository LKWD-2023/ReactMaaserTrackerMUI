using Microsoft.EntityFrameworkCore;

namespace ReactMaaserTrackerMUI.Data
{
    public class MaaserTrackerContext : DbContext
    {
        private readonly string _connectionString;

        public MaaserTrackerContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<IncomeSource> IncomeSources { get; set; }
        public DbSet<MaaserPayment> MaaserPayments { get; set; }
        public DbSet<IncomePayment> IncomePayments { get; set; }

    }
}