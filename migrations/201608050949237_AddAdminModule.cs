namespace CorpersWelfareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminModule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Corper", "Batch", c => c.String());
            AddColumn("dbo.Corper", "NyscYear", c => c.String());
            AddColumn("dbo.Corper", "Cds", c => c.String());
            AddColumn("dbo.Corper", "Community", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Corper", "Community");
            DropColumn("dbo.Corper", "Cds");
            DropColumn("dbo.Corper", "NyscYear");
            DropColumn("dbo.Corper", "Batch");
        }
    }
}
