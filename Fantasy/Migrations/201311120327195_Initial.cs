namespace Fantasy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Division",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Team",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Division_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Division", t => t.Division_ID)
                .Index(t => t.Division_ID);

            DropColumn("dbo.Player", "Team");
        }

        public override void Down()
        {
            AddColumn("dbo.Player", "Team", c => c.String());
            DropForeignKey("dbo.Team", "Division_ID", "dbo.Division");
            DropIndex("dbo.Team", new[] { "Division_ID" });
            DropTable("dbo.Team");
            DropTable("dbo.Division");
        }
    }
}