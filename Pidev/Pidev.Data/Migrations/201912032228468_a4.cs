namespace Pidev.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("missionrequest", "wqId", c => c.Int());
            AlterColumn("dbo.waitingQueues", "idmission", c => c.Int());
            CreateIndex("missionrequest", "wqId");
            CreateIndex("dbo.waitingQueues", "idmission");
            AddForeignKey("dbo.waitingQueues", "idmission", "piproject.mission1", "id");
            AddForeignKey("missionrequest", "wqId", "dbo.waitingQueues", "id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.waitingQueues", "idMreq", c => c.Int(nullable: false));
            DropForeignKey("piproject.missionrequest", "wqId", "dbo.waitingQueues");
            DropForeignKey("dbo.waitingQueues", "idmission", "piproject.mission1");
            DropIndex("dbo.waitingQueues", new[] { "idmission" });
            DropIndex("piproject.missionrequest", new[] { "wqId" });
            AlterColumn("dbo.waitingQueues", "idmission", c => c.Int(nullable: false));
            DropColumn("piproject.missionrequest", "wqId");
        }
    }
}
