namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroupFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "Group", c => c.String());
            DropColumn("dbo.PatientMasters", "GroupPositve");
            DropColumn("dbo.PatientMasters", "GroupNegative");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientMasters", "GroupNegative", c => c.String());
            AddColumn("dbo.PatientMasters", "GroupPositve", c => c.String());
            DropColumn("dbo.PatientMasters", "Group");
        }
    }
}
