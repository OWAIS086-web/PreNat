namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fiic : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Telephones_Landline", c => c.String());
            AlterColumn("dbo.Patients", "Cell_Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "Cell_Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "Telephones_Landline", c => c.Int(nullable: false));
        }
    }
}
