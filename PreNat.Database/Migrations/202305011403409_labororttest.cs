namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class labororttest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LaboratoryTests", "GroupPositve", c => c.String());
            AddColumn("dbo.LaboratoryTests", "GroupNegative", c => c.String());
            DropColumn("dbo.LaboratoryTests", "Group");
            DropColumn("dbo.LaboratoryTests", "Laboratory_Tests");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LaboratoryTests", "Laboratory_Tests", c => c.String());
            AddColumn("dbo.LaboratoryTests", "Group", c => c.String());
            DropColumn("dbo.LaboratoryTests", "GroupNegative");
            DropColumn("dbo.LaboratoryTests", "GroupPositve");
        }
    }
}
