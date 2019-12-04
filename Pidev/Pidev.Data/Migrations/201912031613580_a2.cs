namespace Pidev.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("collaborator", "notea", c => c.Int(nullable: false));
            }
        
        public override void Down()
        {
            AddColumn("piproject.collaborator", "note", c => c.Int(nullable: false));
            DropColumn("piproject.collaborator", "notea");
        }
    }
}
