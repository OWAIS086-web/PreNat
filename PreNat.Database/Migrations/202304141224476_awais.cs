namespace PreNat.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class awais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Backgrounds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tbc = c.String(),
                        Diabetes = c.String(),
                        Hypertension = c.String(),
                        Eclampsia = c.String(),
                        Preeclampsia = c.String(),
                        Surgery = c.String(),
                        Infertility = c.String(),
                        Cardiopathy = c.String(),
                        Nephropathy = c.String(),
                        Violence = c.String(),
                        VIH = c.String(),
                        Migraine = c.String(),
                        Enf_Tromboembólica = c.String(),
                        IMC29 = c.String(),
                        IMC39 = c.String(),
                        Disc_Sang = c.String(),
                        other_dises = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChronologyPregnancies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReliableFUM = c.Int(nullable: false),
                        UltrasoundObstetrics = c.Int(nullable: false),
                        FPP = c.Int(nullable: false),
                        FPC = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Immunizations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TetanusDiphtheria = c.String(),
                        TetanusDiphtheria_Date = c.Int(nullable: false),
                        TetanusDiphtheria_Quantity = c.Int(nullable: false),
                        TDAP = c.String(),
                        TDAP_Date = c.Int(nullable: false),
                        TDAP_Quantity = c.Int(nullable: false),
                        Influenza = c.String(),
                        Influenza_Date = c.Int(nullable: false),
                        Influenza_Quantity = c.Int(nullable: false),
                        Rubella = c.String(),
                        Rubella_Date = c.Int(nullable: false),
                        Rubella_Quantity = c.Int(nullable: false),
                        Hepatitis_B = c.String(),
                        Hepatitis_B_Date = c.Int(nullable: false),
                        Hepatitis_B_Quantity = c.Int(nullable: false),
                        Hepatitis_A = c.String(),
                        Hepatitis_A_Date = c.Int(nullable: false),
                        Hepatitis_A_Quantity = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LaboratoryTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Group = c.String(),
                        SanguineoGroup = c.String(),
                        Laboratory_Tests = c.String(),
                        VDRL = c.String(),
                        Syphilis = c.String(),
                        VIH_L = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ObstetricGynecologyClinicals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlannedPregnancy = c.String(),
                        DesiredPregnancy = c.String(),
                        PreconceptionCounseling = c.String(),
                        ContraceptiveFailure = c.String(),
                        DefinitiveMethod = c.String(),
                        Failure = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Obstetrichistories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Gestationes_Pregnancies = c.Int(nullable: false),
                        Delivery = c.Int(nullable: false),
                        Term = c.Int(nullable: false),
                        Premature = c.Int(nullable: false),
                        Vaginal = c.Int(nullable: false),
                        Cesareas = c.Int(nullable: false),
                        Abortions = c.Int(nullable: false),
                        Gemerales = c.Int(nullable: false),
                        Ectopicos = c.Int(nullable: false),
                        Obitos = c.Int(nullable: false),
                        Springs = c.Int(nullable: false),
                        Live_Births = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surnames = c.String(),
                        Type_of_Identity = c.Int(nullable: false),
                        Department_of_residence = c.String(),
                        City_Municipality_of_residence = c.String(),
                        Address_of_residence = c.String(),
                        Telephones_Landline = c.Int(nullable: false),
                        Cell_Phone = c.Int(nullable: false),
                        Date_of_birth = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Race_DANE_Information = c.String(),
                        Ethnicity_DANE_Information = c.String(),
                        Level_of_Education = c.String(),
                        Marital_status = c.String(),
                        Affiliation_regime = c.String(),
                        EPS_IPS = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PregnancyConfirmations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FUM = c.String(),
                        FUM_Date = c.Int(nullable: false),
                        Positive_HCG_presence = c.String(),
                        Positive_HCG_presence_Date = c.Int(nullable: false),
                        Upload_document1 = c.String(),
                        Positive_TV_ultrasound = c.String(),
                        Positive_TV_ultrasound_Date = c.Int(nullable: false),
                        Upload_document2 = c.String(),
                        PregnancyConfirm = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PsychosocialAssessments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SmokerActive = c.String(),
                        PassiveSmoking = c.String(),
                        ConsumeAlcohol = c.String(),
                        ConsumeAlucinogenos = c.String(),
                        DomesticViolence = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PsychosocialAssessments");
            DropTable("dbo.PregnancyConfirmations");
            DropTable("dbo.Patients");
            DropTable("dbo.Obstetrichistories");
            DropTable("dbo.ObstetricGynecologyClinicals");
            DropTable("dbo.LaboratoryTests");
            DropTable("dbo.Immunizations");
            DropTable("dbo.ChronologyPregnancies");
            DropTable("dbo.Backgrounds");
        }
    }
}
