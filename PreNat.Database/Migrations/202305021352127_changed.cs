namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Obstetrichistories", "Gestation", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "NoOfPregnancy", c => c.Int(nullable: false));
            DropColumn("dbo.Obstetrichistories", "Gestationes_Pregnancies");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Obstetrichistories", "Gestationes_Pregnancies", c => c.Int(nullable: false));
            DropColumn("dbo.Obstetrichistories", "NoOfPregnancy");
            DropColumn("dbo.Obstetrichistories", "Gestation");
        }
    }
}
