namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateComponent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batch",
                c => new
                    {
                        BatchID = c.Int(nullable: false, identity: true),
                        BatchName = c.String(),
                        Corper_CorperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BatchID)
                .ForeignKey("dbo.Corper", t => t.Corper_CorperID, cascadeDelete: true)
                .Index(t => t.Corper_CorperID);
            
            CreateTable(
                "dbo.Cds",
                c => new
                    {
                        CdsID = c.Int(nullable: false, identity: true),
                        CdsName = c.String(),
                        Corper_CorperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CdsID)
                .ForeignKey("dbo.Corper", t => t.Corper_CorperID, cascadeDelete: true)
                .Index(t => t.Corper_CorperID);
            
            CreateTable(
                "dbo.Community",
                c => new
                    {
                        CommunityID = c.Int(nullable: false, identity: true),
                        CommunityName = c.String(),
                        Corper_CorperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommunityID)
                .ForeignKey("dbo.Corper", t => t.Corper_CorperID, cascadeDelete: true)
                .Index(t => t.Corper_CorperID);
            
            CreateTable(
                "dbo.NyscYear",
                c => new
                    {
                        NyscYearID = c.Int(nullable: false, identity: true),
                        NyscYearName = c.String(),
                        Corper_CorperID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NyscYearID)
                .ForeignKey("dbo.Corper", t => t.Corper_CorperID, cascadeDelete: true)
                .Index(t => t.Corper_CorperID);
            
            AddColumn("dbo.Corper", "CommunityID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "NyscYearID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "CdsID", c => c.Int(nullable: false));
            AddColumn("dbo.Corper", "BatchID", c => c.Int(nullable: false));
            DropColumn("dbo.Corper", "Community");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Corper", "Community", c => c.String());
            DropForeignKey("dbo.NyscYear", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.Community", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.Cds", "Corper_CorperID", "dbo.Corper");
            DropForeignKey("dbo.Batch", "Corper_CorperID", "dbo.Corper");
            DropIndex("dbo.NyscYear", new[] { "Corper_CorperID" });
            DropIndex("dbo.Community", new[] { "Corper_CorperID" });
            DropIndex("dbo.Cds", new[] { "Corper_CorperID" });
            DropIndex("dbo.Batch", new[] { "Corper_CorperID" });
            DropColumn("dbo.Corper", "BatchID");
            DropColumn("dbo.Corper", "CdsID");
            DropColumn("dbo.Corper", "NyscYearID");
            DropColumn("dbo.Corper", "CommunityID");
            DropTable("dbo.NyscYear");
            DropTable("dbo.Community");
            DropTable("dbo.Cds");
            DropTable("dbo.Batch");
        }
    }
}
