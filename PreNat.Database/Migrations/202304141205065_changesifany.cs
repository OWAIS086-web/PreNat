namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesifany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LaboratoryTests", "VIH_L", c => c.String());
            DropColumn("dbo.LaboratoryTests", "VIH");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LaboratoryTests", "VIH", c => c.String());
            DropColumn("dbo.LaboratoryTests", "VIH_L");
        }
    }
}
