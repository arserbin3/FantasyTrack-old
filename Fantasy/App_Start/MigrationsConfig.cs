namespace Fantasy.App_Start
{
    using System.Data.Entity.Migrations;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FantasyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Fantasy.Models.FantasyContext";
        }

        // This method will be called after migrating to the latest version.
        protected override void Seed(FantasyContext context)
        {
            // wipe all data
            context.Players.RemoveRange(context.Players);
            context.SaveChanges();

            // TODO: replace with real data
            context.Players.AddOrUpdate(
                x => x.Name,
                new Player { Name = "Ray Rice", Team = "Baltimore Ravens", Position = "RB" });
        }
    }
}