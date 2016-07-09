namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Corpertable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MonthlyDues", "CorperID", "dbo.Corper");
            DropIndex("dbo.MonthlyDues", new[] { "CorperID" });
            DropColumn("dbo.Corper", "MonthlyID");
            DropTable("dbo.MonthlyDues");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.MonthlyID);
            
            AddColumn("dbo.Corper", "MonthlyID", c => c.Int(nullable: false));
            CreateIndex("dbo.MonthlyDues", "CorperID");
            AddForeignKey("dbo.MonthlyDues", "CorperID", "dbo.Corper", "CorperID", cascadeDelete: true);
        }
    }
}
