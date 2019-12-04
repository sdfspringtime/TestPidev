namespace Pidev.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.waitingQueues",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idmission = c.Int(nullable: false),
                        idMreq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("mission1", "maxcollab", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("piproject.mission1", "maxcollab");
            DropTable("dbo.waitingQueues");
        }
    }
}
