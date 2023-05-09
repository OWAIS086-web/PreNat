namespace PreNat.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class newchnges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "TetanusCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.PatientMasters", "TdapCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.PatientMasters", "InfluencaCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.PatientMasters", "RubellaCheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.PatientMasters", "Hepatitis_ACheck", c => c.Boolean(nullable: false));
            AddColumn("dbo.PatientMasters", "Hepatitis_BCheck", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "Hepatitis_BCheck");
            DropColumn("dbo.PatientMasters", "Hepatitis_ACheck");
            DropColumn("dbo.PatientMasters", "RubellaCheck");
            DropColumn("dbo.PatientMasters", "InfluencaCheck");
            DropColumn("dbo.PatientMasters", "TdapCheck");
            DropColumn("dbo.PatientMasters", "TetanusCheck");
        }
    }
}
