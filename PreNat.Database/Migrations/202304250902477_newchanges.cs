namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Backgrounds", "HIV", c => c.String());
            AddColumn("dbo.Backgrounds", "Thromboembolic", c => c.String());
            AddColumn("dbo.Backgrounds", "BMI_29", c => c.String());
            AddColumn("dbo.Backgrounds", "BMI_39", c => c.String());
            AddColumn("dbo.Backgrounds", "Other", c => c.String());
            DropColumn("dbo.Backgrounds", "VIH");
            DropColumn("dbo.Backgrounds", "Enf_Tromboembólica");
            DropColumn("dbo.Backgrounds", "IMC29");
            DropColumn("dbo.Backgrounds", "IMC39");
            DropColumn("dbo.Backgrounds", "other_dises");
            DropColumn("dbo.PregnancyConfirmations", "Positive_HCG_presence");
            DropColumn("dbo.PregnancyConfirmations", "Positive_TV_ultrasound");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PregnancyConfirmations", "Positive_TV_ultrasound", c => c.String());
            AddColumn("dbo.PregnancyConfirmations", "Positive_HCG_presence", c => c.String());
            AddColumn("dbo.Backgrounds", "other_dises", c => c.String());
            AddColumn("dbo.Backgrounds", "IMC39", c => c.String());
            AddColumn("dbo.Backgrounds", "IMC29", c => c.String());
            AddColumn("dbo.Backgrounds", "Enf_Tromboembólica", c => c.String());
            AddColumn("dbo.Backgrounds", "VIH", c => c.String());
            DropColumn("dbo.Backgrounds", "Other");
            DropColumn("dbo.Backgrounds", "BMI_39");
            DropColumn("dbo.Backgrounds", "BMI_29");
            DropColumn("dbo.Backgrounds", "Thromboembolic");
            DropColumn("dbo.Backgrounds", "HIV");
        }
    }
}
