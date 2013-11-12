namespace Fantasy.Models
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class FantasyContext : DbContext
    {
        public FantasyContext()
            : base("FantasyContext")
        {
            Database.SetInitializer<FantasyContext>(null);
        }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}