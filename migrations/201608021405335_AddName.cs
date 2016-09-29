namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cds",
                c => new
                    {
                        CdsID = c.Int(nullable: false, identity: true),
                        CdsName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CdsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cds");
        }
    }
}
