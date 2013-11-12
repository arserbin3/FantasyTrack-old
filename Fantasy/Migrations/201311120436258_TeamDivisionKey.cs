namespace Fantasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamDivisionKey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Team", name: "Division_ID", newName: "DivisionID");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Team", name: "DivisionID", newName: "Division_ID");
        }
    }
}
