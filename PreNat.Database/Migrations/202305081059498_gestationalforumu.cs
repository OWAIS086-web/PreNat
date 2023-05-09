namespace PreNat.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class gestationalforumu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "GestationalFormula", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "GestationalFormula");
        }
    }
}
