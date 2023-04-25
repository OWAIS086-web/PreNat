namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PregnancyConfirmations", "WeeksPregnant", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PregnancyConfirmations", "WeeksPregnant");
        }
    }
}
