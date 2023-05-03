namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minorchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "CreatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "CreatedBy");
        }
    }
}
