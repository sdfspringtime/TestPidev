namespace Pidev.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mission1collaborator",
                c => new
                    {
                        mission1_id = c.Int(nullable: false),
                        collaborator_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.mission1_id, t.collaborator_id })
                .ForeignKey("piproject.mission1", t => t.mission1_id, cascadeDelete: true)
                .ForeignKey("piproject.collaborator", t => t.collaborator_id, cascadeDelete: true)
                .Index(t => t.mission1_id)
                .Index(t => t.collaborator_id);
            
            AddColumn("missionrequest", "isconfirmed", c => c.Boolean(nullable: false));
            AddColumn("missionrequest", "wqId", c => c.Int());
            AddColumn("dbo.waitingQueues", "isConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.waitingQueues", "miss_id", c => c.Int());
            CreateIndex("piproject.missionrequest", "wqId");
            CreateIndex("dbo.waitingQueues", "miss_id");
            AddForeignKey("dbo.waitingQueues", "miss_id", "piproject.mission1", "id");
            AddForeignKey("piproject.missionrequest", "wqId", "dbo.waitingQueues", "id");
            DropColumn("dbo.waitingQueues", "idmission");
            DropColumn("dbo.waitingQueues", "idMreq");
        }
        
        public override void Down()
        {
            AddColumn("dbo.waitingQueues", "idMreq", c => c.Int(nullable: false));
            AddColumn("dbo.waitingQueues", "idmission", c => c.Int(nullable: false));
            DropForeignKey("piproject.missionrequest", "wqId", "dbo.waitingQueues");
            DropForeignKey("dbo.waitingQueues", "miss_id", "piproject.mission1");
            DropForeignKey("dbo.mission1collaborator", "collaborator_id", "piproject.collaborator");
            DropForeignKey("dbo.mission1collaborator", "mission1_id", "piproject.mission1");
            DropIndex("dbo.mission1collaborator", new[] { "collaborator_id" });
            DropIndex("dbo.mission1collaborator", new[] { "mission1_id" });
            DropIndex("dbo.waitingQueues", new[] { "miss_id" });
            DropIndex("piproject.missionrequest", new[] { "wqId" });
            DropColumn("dbo.waitingQueues", "miss_id");
            DropColumn("dbo.waitingQueues", "isConfirmed");
            DropColumn("piproject.missionrequest", "wqId");
            DropColumn("piproject.missionrequest", "isconfirmed");
            DropTable("dbo.mission1collaborator");
        }
    }
}
