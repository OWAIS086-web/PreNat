namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reasonsadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "ReasonsList", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "ReasonsList");
        }
    }
}
