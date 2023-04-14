using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class MainListingViewModel
    {
        public List<Patient> Patients { get; set; }
        public string SearchTerm { get; set; }
    }

    public class MainActionViewModel
    {
        //patient
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Type_of_Identity { get; set; }
        public string Department_of_residence { get; set; }
        public string City_Municipality_of_residence { get; set; }
        public string Address_of_residence { get; set; }
        public int Telephones_Landline { get; set; }
        public int Cell_Phone { get; set; }
        public int Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Race_DANE_Information { get; set; }
        public string Ethnicity_DANE_Information { get; set; }
        public string Level_of_Education { get; set; }
        public string Marital_status { get; set; }
        public string Affiliation_regime { get; set; }
        public string EPS_IPS { get; set; }

        // background
        public string Tbc { get; set; }
        public string Diabetes { get; set; }
        public string Hypertension { get; set; }
        public string Eclampsia { get; set; }
        public string Preeclampsia { get; set; }
        public string Surgery { get; set; }
        public string Infertility { get; set; }
        public string Cardiopathy { get; set; }
        public string Nephropathy { get; set; }
        public string Violence { get; set; }
        public string VIH { get; set; }
        public string Migraine { get; set; }
        public string Enf_Tromboembólica { get; set; }
        public string IMC29 { get; set; }
        public string IMC39 { get; set; }
        public string Disc_Sang { get; set; }
        public string other_dises { get; set; }
        public int PatientID { get; set; }

        //ChronologyPregnancy
        public int ReliableFUM { get; set; }
        public int UltrasoundObstetrics { get; set; }
        public int FPP { get; set; }
        public int FPC { get; set; }

        //Immunizations

        public string TetanusDiphtheria { get; set; }
        public int TetanusDiphtheria_Date { get; set; }
        public int TetanusDiphtheria_Quantity { get; set; }
        public string TDAP { get; set; }
        public int TDAP_Date { get; set; }
        public int TDAP_Quantity { get; set; }
        public string Influenza { get; set; }
        public int Influenza_Date { get; set; }
        public int Influenza_Quantity { get; set; }
        public string Rubella { get; set; }
        public int Rubella_Date { get; set; }
        public int Rubella_Quantity { get; set; }
        public string Hepatitis_B { get; set; }
        public int Hepatitis_B_Date { get; set; }
        public int Hepatitis_B_Quantity { get; set; }
        public string Hepatitis_A { get; set; }
        public int Hepatitis_A_Date { get; set; }
        public int Hepatitis_A_Quantity { get; set; }

        //LaboratoryTests
        public string Group { get; set; }
        public string SanguineoGroup { get; set; }
        public string Laboratory_Tests { get; set; }
        public string VDRL { get; set; }
        public string Syphilis { get; set; }
        public string VIH_L { get; set; }

        //ObstetricGynecologyClinical
        public string PlannedPregnancy { get; set; }
        public string DesiredPregnancy { get; set; }
        public string PreconceptionCounseling { get; set; }
        public string ContraceptiveFailure { get; set; }
        public string DefinitiveMethod { get; set; }
        public string Failure { get; set; }

        //Obstetrichistory
        public int Delivery { get; set; }
        public int Term { get; set; }
        public int Premature { get; set; }
        public int Vaginal { get; set; }
        public int Cesareas { get; set; }
        public int Abortions { get; set; }
        public int Gemerales { get; set; }
        public int Ectopicos { get; set; }
        public int Obitos { get; set; }
        public int Springs { get; set; }
        public int Live_Births { get; set; }

        //PregnancyConfirmation
        public string FUM { get; set; }
        public int FUM_Date { get; set; }
        public string Positive_HCG_presence { get; set; }
        public int Positive_HCG_presence_Date { get; set; }
        public string Upload_document1 { get; set; }
        public string Positive_TV_ultrasound { get; set; }
        public int Positive_TV_ultrasound_Date { get; set; }
        public string Upload_document2 { get; set; }
        public string PregnancyConfirm { get; set; }

        //PsychosocialAssessment
        public string SmokerActive { get; set; }
        public string PassiveSmoking { get; set; }
        public string ConsumeAlcohol { get; set; }
        public string ConsumeAlucinogenos { get; set; }
        public string DomesticViolence { get; set; }

    }
}