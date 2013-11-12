namespace Fantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerTeamKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "TeamID", c => c.Int());
            CreateIndex("dbo.Player", "TeamID");
            AddForeignKey("dbo.Player", "TeamID", "dbo.Team", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "TeamID", "dbo.Team");
            DropIndex("dbo.Player", new[] { "TeamID" });
            DropColumn("dbo.Player", "TeamID");
        }
    }
}
