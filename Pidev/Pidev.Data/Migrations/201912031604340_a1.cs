namespace Pidev.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("piproject.missionrequest", "idCollab", "piproject.collaborator");
            DropForeignKey("piproject.missionrequest", "man_id", "piproject.collaborator");
            DropForeignKey("piproject.fixedfee", "man_id", "piproject.collaborator");
            DropForeignKey("piproject.expform", "collab_id", "piproject.collaborator");
            DropForeignKey("piproject.expform", "man_id", "piproject.collaborator");
            DropForeignKey("piproject.missionrequest", "man_id", "piproject.manager");
            DropForeignKey("piproject.fixedfee", "man_id", "piproject.manager");
            DropForeignKey("piproject.mission1", "ffee_id", "piproject.fixedfee");
            DropForeignKey("piproject.missionrequest", "idMission", "piproject.mission1");
            DropForeignKey("piproject.fixedfee", "miss_id", "piproject.mission1");
            DropForeignKey("piproject.expform", "miss_id", "piproject.mission1");
            DropForeignKey("piproject.expform", "man_id", "piproject.manager");
            DropForeignKey("dbo.collaborator_expform", "Collaborator_id", "piproject.collaborator");
            DropForeignKey("dbo.collaborator_expform", "Eform_EF_Id", "piproject.expform");
            DropForeignKey("piproject.collaborator", "manager_id", "piproject.collaborator");
            DropIndex("dbo.collaborator_expform", new[] { "Collaborator_id" });
            DropIndex("dbo.collaborator_expform", new[] { "Eform_EF_Id" });
            DropIndex("piproject.missionrequest", new[] { "man_id" });
            DropIndex("piproject.missionrequest", new[] { "idMission" });
            DropIndex("piproject.missionrequest", new[] { "idCollab" });
            DropIndex("piproject.mission1", new[] { "ffee_id" });
            DropIndex("piproject.fixedfee", new[] { "miss_id" });
            DropIndex("piproject.fixedfee", new[] { "man_id" });
            DropIndex("piproject.expform", new[] { "miss_id" });
            DropIndex("piproject.expform", new[] { "man_id" });
            DropIndex("piproject.expform", new[] { "collab_id" });
            DropIndex("piproject.collaborator", new[] { "manager_id" });
            DropTable("dbo.collaborator_expform");
            DropTable("piproject.test");
            DropTable("piproject.mission");
            DropTable("piproject.expenseform");
            DropTable("piproject.missionrequest");
            DropTable("piproject.mission1");
            DropTable("piproject.fixedfee");
            DropTable("piproject.manager");
            DropTable("piproject.expform");
            DropTable("piproject.collaborator");
        }
    }
}
