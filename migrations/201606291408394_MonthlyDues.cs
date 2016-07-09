namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonthlyDues : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthlyDues",
                c => new
                    {
                        MonthlyID = c.Int(nullable: false, identity: true),
                        CorperID = c.Int(nullable: false),
                        Month = c.String(),
                        AmountMonthly = c.Double(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MonthlyID)
                .ForeignKey("dbo.Corper", t => t.CorperID, cascadeDelete: true)
                .Index(t => t.CorperID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonthlyDues", "CorperID", "dbo.Corper");
            DropIndex("dbo.MonthlyDues", new[] { "CorperID" });
            DropTable("dbo.MonthlyDues");
        }
    }
}
