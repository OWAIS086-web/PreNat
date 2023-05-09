namespace PreNat.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class immchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChronologyPregnancies", "ProbableDateOfDelivery", c => c.DateTime(nullable: false));
            AddColumn("dbo.ChronologyPregnancies", "ProbableDateOfConception", c => c.DateTime(nullable: false));
            AddColumn("dbo.Immunizations", "TetanusDiphtheriaNo", c => c.String());
            AddColumn("dbo.Immunizations", "TetanusDiphtheriaYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "TetanusDiphtheriaYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "TetanusDiphtheria_Dozes", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "TdapNo", c => c.String());
            AddColumn("dbo.Immunizations", "TdapYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "TdapYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Tdap_Dozes", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "InfluenzaNo", c => c.String());
            AddColumn("dbo.Immunizations", "InfluenzaYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "InfluenzaYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Influenza_Dozes", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "RubellaNo", c => c.String());
            AddColumn("dbo.Immunizations", "RubellaYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "RubellaYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Rubella_Dozes", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Hepatitis_ANo", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_AYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_AYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_A_Dozes", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Hepatitis_BNo", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_BYesPrevPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_BYesDuringPreg", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_B_Dozes", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "TetanusDiphtheria_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Immunizations", "Tdap_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Immunizations", "Influenza_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Immunizations", "Rubella_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Immunizations", "Hepatitis_B_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Immunizations", "Hepatitis_A_Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Immunizations", "TetanusDiphtheria");
            DropColumn("dbo.Immunizations", "TetanusDiphtheria_Quantity");
            DropColumn("dbo.Immunizations", "TDAP");
            DropColumn("dbo.Immunizations", "TDAP_Quantity");
            DropColumn("dbo.Immunizations", "Influenza");
            DropColumn("dbo.Immunizations", "Influenza_Quantity");
            DropColumn("dbo.Immunizations", "Rubella");
            DropColumn("dbo.Immunizations", "Rubella_Quantity");
            DropColumn("dbo.Immunizations", "Hepatitis_B");
            DropColumn("dbo.Immunizations", "Hepatitis_B_Quantity");
            DropColumn("dbo.Immunizations", "Hepatitis_A");
            DropColumn("dbo.Immunizations", "Hepatitis_A_Quantity");
        }

        public override void Down()
        {
            AddColumn("dbo.Immunizations", "Hepatitis_A_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Hepatitis_A", c => c.String());
            AddColumn("dbo.Immunizations", "Hepatitis_B_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Hepatitis_B", c => c.String());
            AddColumn("dbo.Immunizations", "Rubella_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Rubella", c => c.String());
            AddColumn("dbo.Immunizations", "Influenza_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "Influenza", c => c.String());
            AddColumn("dbo.Immunizations", "TDAP_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "TDAP", c => c.String());
            AddColumn("dbo.Immunizations", "TetanusDiphtheria_Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Immunizations", "TetanusDiphtheria", c => c.String());
            AlterColumn("dbo.Immunizations", "Hepatitis_A_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "Hepatitis_B_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "Rubella_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "Influenza_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "Tdap_Date", c => c.Int(nullable: false));
            AlterColumn("dbo.Immunizations", "TetanusDiphtheria_Date", c => c.Int(nullable: false));
            DropColumn("dbo.Immunizations", "Hepatitis_B_Dozes");
            DropColumn("dbo.Immunizations", "Hepatitis_BYesDuringPreg");
            DropColumn("dbo.Immunizations", "Hepatitis_BYesPrevPreg");
            DropColumn("dbo.Immunizations", "Hepatitis_BNo");
            DropColumn("dbo.Immunizations", "Hepatitis_A_Dozes");
            DropColumn("dbo.Immunizations", "Hepatitis_AYesDuringPreg");
            DropColumn("dbo.Immunizations", "Hepatitis_AYesPrevPreg");
            DropColumn("dbo.Immunizations", "Hepatitis_ANo");
            DropColumn("dbo.Immunizations", "Rubella_Dozes");
            DropColumn("dbo.Immunizations", "RubellaYesDuringPreg");
            DropColumn("dbo.Immunizations", "RubellaYesPrevPreg");
            DropColumn("dbo.Immunizations", "RubellaNo");
            DropColumn("dbo.Immunizations", "Influenza_Dozes");
            DropColumn("dbo.Immunizations", "InfluenzaYesDuringPreg");
            DropColumn("dbo.Immunizations", "InfluenzaYesPrevPreg");
            DropColumn("dbo.Immunizations", "InfluenzaNo");
            DropColumn("dbo.Immunizations", "Tdap_Dozes");
            DropColumn("dbo.Immunizations", "TdapYesDuringPreg");
            DropColumn("dbo.Immunizations", "TdapYesPrevPreg");
            DropColumn("dbo.Immunizations", "TdapNo");
            DropColumn("dbo.Immunizations", "TetanusDiphtheria_Dozes");
            DropColumn("dbo.Immunizations", "TetanusDiphtheriaYesDuringPreg");
            DropColumn("dbo.Immunizations", "TetanusDiphtheriaYesPrevPreg");
            DropColumn("dbo.Immunizations", "TetanusDiphtheriaNo");
            DropColumn("dbo.ChronologyPregnancies", "ProbableDateOfConception");
            DropColumn("dbo.ChronologyPregnancies", "ProbableDateOfDelivery");
        }
    }
}
