namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypesfixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "Type_of_Identity", c => c.String());
            AlterColumn("dbo.Patients", "Date_of_birth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "FUM", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "Positive_HCG_presence_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "Positive_TV_ultrasound_Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.PregnancyConfirmations", "FUM_Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PregnancyConfirmations", "FUM_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "Positive_TV_ultrasound_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "Positive_HCG_presence_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.PregnancyConfirmations", "FUM", c => c.String());
            AlterColumn("dbo.Patients", "Date_of_birth", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "Type_of_Identity", c => c.Int(nullable: false));
        }
    }
}
