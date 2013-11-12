namespace Fantasy.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
            // wipe all data and reset identities
            context.Divisions.RemoveRange(context.Divisions);
            context.Teams.RemoveRange(context.Teams);
            context.Players.RemoveRange(context.Players);
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Division',RESEED,0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Team',RESEED,0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Player',RESEED,0);");
            context.SaveChanges();

            var divisions = new Dictionary<string, Division>
            {
                { "AFC East", new Division { Name = "AFC East" } },
                { "AFC North", new Division { Name = "AFC North" } },
                { "AFC South", new Division { Name = "AFC South" } },
                { "AFC West", new Division { Name = "AFC West" } },
                { "NFC East", new Division { Name = "NFC East" } },
                { "NFC North", new Division { Name = "NFC North" } },
                { "NFC South", new Division { Name = "NFC South" } },
                { "NFC West", new Division { Name = "NFC West" } },
            };
            context.Divisions.AddOrUpdate(
                x => x.Name,
                divisions.Select(x => x.Value).ToArray());

            var teams = new Dictionary<string, Team>
            {
                { "49ers", new Team { Name = "49ers", City = "San Francisco", Division = divisions["NFC West"] } },
                { "Bears", new Team { Name = "Bears", City = "Chicago", Division = divisions["NFC North"] } },
                { "Bengals", new Team { Name = "Bengals", City = "Cincinnati", Division = divisions["AFC North"] } },
                { "Bills", new Team { Name = "Bills", City = "Buffalo", Division = divisions["AFC East"] } },
                { "Broncos", new Team { Name = "Broncos", City = "Denver", Division = divisions["AFC West"] } },
                { "Browns", new Team { Name = "Browns", City = "Cleveland", Division = divisions["AFC North"] } },
                { "Buccaneers", new Team { Name = "Buccaneers", City = "Tampa Bay", Division = divisions["NFC South"] } },
                { "Cardinals", new Team { Name = "Cardinals", City = "Arizona", Division = divisions["NFC West"] } },
                { "Chargers", new Team { Name = "Chargers", City = "San Diego", Division = divisions["AFC West"] } },
                { "Chiefs", new Team { Name = "Chiefs", City = "Kansas City", Division = divisions["AFC West"] } },
                { "Colts", new Team { Name = "Colts", City = "Indianapolis", Division = divisions["AFC South"] } },
                { "Cowboys", new Team { Name = "Cowboys", City = "Dallas", Division = divisions["NFC East"] } },
                { "Dolphins", new Team { Name = "Dolphins", City = "Miami", Division = divisions["AFC East"] } },
                { "Eagles", new Team { Name = "Eagles", City = "Philadelphia", Division = divisions["NFC East"] } },
                { "Falcons", new Team { Name = "Falcons", City = "Atlanta", Division = divisions["NFC South"] } },
                { "Giants", new Team { Name = "Giants", City = "New York", Division = divisions["NFC East"] } },
                { "Jaguars", new Team { Name = "Jaguars", City = "Jacksonville", Division = divisions["AFC South"] } },
                { "Jets", new Team { Name = "Jets", City = "New York", Division = divisions["AFC East"] } },
                { "Lions", new Team { Name = "Lions", City = "Detroit", Division = divisions["NFC North"] } },
                { "Packers", new Team { Name = "Packers", City = "Green Bay", Division = divisions["NFC North"] } },
                { "Panthers", new Team { Name = "Panthers", City = "Carolina", Division = divisions["NFC South"] } },
                { "Patriots", new Team { Name = "Patriots", City = "New England", Division = divisions["AFC East"] } },
                { "Raiders", new Team { Name = "Raiders", City = "Oakland", Division = divisions["AFC West"] } },
                { "Rams", new Team { Name = "Rams", City = "St. Louis", Division = divisions["NFC West"] } },
                { "Ravens", new Team { Name = "Ravens", City = "Baltimore", Division = divisions["AFC North"] } },
                { "Redskins", new Team { Name = "Redskins", City = "Washington", Division = divisions["NFC East"] } },
                { "Saints", new Team { Name = "Saints", City = "New Orleans", Division = divisions["NFC South"] } },
                { "Seahawks", new Team { Name = "Seahawks", City = "Seattle", Division = divisions["NFC West"] } },
                { "Steelers", new Team { Name = "Steelers", City = "Pittsburgh", Division = divisions["AFC North"] } },
                { "Texans", new Team { Name = "Texans", City = "Houston", Division = divisions["AFC South"] } },
                { "Titans", new Team { Name = "Titans", City = "Tennessee", Division = divisions["AFC South"] } },
                { "Vikings", new Team { Name = "Vikings", City = "Minnesota", Division = divisions["NFC North"] } },
            };
            context.Teams.AddOrUpdate(
                x => x.Name,
                teams.Select(x => x.Value).ToArray());

            // TODO: replace with real data
            context.Players.AddOrUpdate(
                x => x.Name,
                new Player { Name = "Ray Rice3", Position = "RB", Team = teams["Ravens"] });
        }
    }
}