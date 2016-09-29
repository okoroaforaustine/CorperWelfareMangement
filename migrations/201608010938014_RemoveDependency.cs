namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDependency : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Batch", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.Cds", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.Community", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.NyscYear", "Corper_CorperID", "dbo.Corper");
            DropIndex("dbo.Batch", new[] { "Corper_CorperID" });
            DropIndex("dbo.Cds", new[] { "Corper_CorperID" });
            DropIndex("dbo.Community", new[] { "Corper_CorperID" });
            DropIndex("dbo.NyscYear", new[] { "Corper_CorperID" });
            DropColumn("dbo.Batch", "Corper_CorperID");
            DropColumn("dbo.Corper", "CommunityID");
            DropColumn("dbo.Corper", "NyscYearID");
            DropColumn("dbo.Corper", "CdsID");
            DropColumn("dbo.Corper", "BatchID");
            DropColumn("dbo.Cds", "Corper_CorperID");
            DropColumn("dbo.Community", "Corper_CorperID");
            DropColumn("dbo.NyscYear", "Corper_CorperID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NyscYear", "Corper_CorperID", c => c.Int(nullable: false));
            AddColumn("dbo.Community", "Corper_CorperID", c => c.Int(nullable: false));
            AddColumn("dbo.Cds", "Corper_CorperID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "BatchID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "CdsID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "NyscYearID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "CommunityID", c => c.Int(nullable: false));
            AddColumn("dbo.Batch", "Corper_CorperID", c => c.Int(nullable: false));
            CreateIndex("dbo.NyscYear", "Corper_CorperID");
            CreateIndex("dbo.Community", "Corper_CorperID");
            CreateIndex("dbo.Cds", "Corper_CorperID");
            CreateIndex("dbo.Batch", "Corper_CorperID");
            AddForeignKey("dbo.NyscYear", "Corper_CorperID", "dbo.Corper", "CorperID", cascadeDelete: true);
            AddForeignKey("dbo.Community", "Corper_CorperID", "dbo.Corper", "CorperID", cascadeDelete: true);
            AddForeignKey("dbo.Cds", "Corper_CorperID", "dbo.Corper", "CorperID", cascadeDelete: true);
            AddForeignKey("dbo.Batch", "Corper_CorperID", "dbo.Corper", "CorperID", cascadeDelete: true);
        }
    }
}
