namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reportstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "ReportStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "ReportStatus");
        }
    }
}
