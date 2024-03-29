﻿namespace PreNat.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class finalchanges : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Backgrounds");
            DropTable("dbo.ChronologyPregnancies");
            DropTable("dbo.Immunizations");
            DropTable("dbo.LaboratoryTests");
            DropTable("dbo.ObstetricGynecologyClinicals");
            DropTable("dbo.Obstetrichistories");
            DropTable("dbo.Patients");
            DropTable("dbo.PregnancyConfirmations");
            DropTable("dbo.PsychosocialAssessments");
        }

        public override void Down()
        {
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

            CreateTable(
                "dbo.PregnancyConfirmations",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FUM = c.DateTime(nullable: false),
                    WeeksPregnant = c.String(),
                    Positive_HCG_presence_Date = c.DateTime(nullable: false),
                    Upload_document1 = c.String(),
                    Positive_TV_ultrasound_Date = c.DateTime(nullable: false),
                    Upload_document2 = c.String(),
                    PregnancyConfirm = c.String(),
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
                    Type_of_Identity = c.String(),
                    Department_of_residence = c.String(),
                    City_Municipality_of_residence = c.String(),
                    Address_of_residence = c.String(),
                    Telephones_Landline = c.String(),
                    Cell_Phone = c.String(),
                    Date_of_birth = c.DateTime(nullable: false),
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
                "dbo.Obstetrichistories",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Gestation = c.Int(nullable: false),
                    NoOfPregnancy = c.Int(nullable: false),
                    Delivery = c.Int(nullable: false),
                    Term = c.Int(nullable: false),
                    Preterm = c.Int(nullable: false),
                    Vaginal = c.Int(nullable: false),
                    Cesareas = c.Int(nullable: false),
                    Abortions = c.Int(nullable: false),
                    Gemerales = c.Int(nullable: false),
                    Ectopic = c.Int(nullable: false),
                    Obitus = c.Int(nullable: false),
                    Molas = c.Int(nullable: false),
                    Live_Births = c.Int(nullable: false),
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
                "dbo.LaboratoryTests",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    GroupPositve = c.String(),
                    SanguineoGroup = c.String(),
                    GroupNegative = c.String(),
                    VDRL = c.String(),
                    Syphilis = c.String(),
                    VIH_L = c.String(),
                    PatientID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Immunizations",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    TetanusDiphtheriaNo = c.String(),
                    TetanusDiphtheriaYesPrevPreg = c.String(),
                    TetanusDiphtheriaYesDuringPreg = c.String(),
                    TetanusDiphtheria_Date = c.DateTime(nullable: false),
                    TetanusDiphtheria_Dozes = c.Int(nullable: false),
                    TdapNo = c.String(),
                    TdapYesPrevPreg = c.String(),
                    TdapYesDuringPreg = c.String(),
                    Tdap_Date = c.DateTime(nullable: false),
                    Tdap_Dozes = c.Int(nullable: false),
                    InfluenzaNo = c.String(),
                    InfluenzaYesPrevPreg = c.String(),
                    InfluenzaYesDuringPreg = c.String(),
                    Influenza_Date = c.DateTime(nullable: false),
                    Influenza_Dozes = c.Int(nullable: false),
                    RubellaNo = c.String(),
                    RubellaYesPrevPreg = c.String(),
                    RubellaYesDuringPreg = c.String(),
                    Rubella_Date = c.DateTime(nullable: false),
                    Rubella_Dozes = c.Int(nullable: false),
                    Hepatitis_ANo = c.String(),
                    Hepatitis_AYesPrevPreg = c.String(),
                    Hepatitis_AYesDuringPreg = c.String(),
                    Hepatitis_A_Date = c.DateTime(nullable: false),
                    Hepatitis_A_Dozes = c.Int(nullable: false),
                    Hepatitis_BNo = c.String(),
                    Hepatitis_BYesPrevPreg = c.String(),
                    Hepatitis_BYesDuringPreg = c.String(),
                    Hepatitis_B_Date = c.DateTime(nullable: false),
                    Hepatitis_B_Dozes = c.Int(nullable: false),
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
                    ProbableDateOfDelivery = c.DateTime(nullable: false),
                    ProbableDateOfConception = c.DateTime(nullable: false),
                    FPC = c.Int(nullable: false),
                    PatientID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

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
                    HIV = c.String(),
                    Migraine = c.String(),
                    Thromboembolic = c.String(),
                    BMI_29 = c.String(),
                    BMI_39 = c.String(),
                    Disc_Sang = c.String(),
                    Other = c.String(),
                    PatientID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

        }
    }
}
