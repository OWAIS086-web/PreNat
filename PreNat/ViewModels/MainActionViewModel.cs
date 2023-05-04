using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNat.ViewModels
{
    public class MainListingViewModel
    {
        public List<PatientMaster> PatientMasters { get; set; }
        public string SearchTerm { get; set; }
    }

    public class MainActionViewModel
    {
        //patient
        public User SignedInUser { get; set; }
        public string Step { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Type_of_Identity { get; set; }  //Dropdown
                                                      //Cedula de Ciudadanía - Cédula de Extranjería - Tarjeta de Identidad 
        public string Department_of_residence { get; set; }
        public string City_Municipality_of_residence { get; set; }
        public string Address_of_residence { get; set; }
        public string Telephones_Landline { get; set; }
        public string Cell_Phone { get; set; }
        public DateTime Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Race_DANE_Information { get; set; }  //Black (Afro-descendant) - Mestizo - White - Indigenous
                                                           //Dropdown
        public string Ethnicity_DANE_Information { get; set; }  //Palenquera   -   Raizal  - Indigenous  -  Gypsy
                                                                //Dropdown
        public string Level_of_Education { get; set; } //Primary - Bachelor - Technical - Professional 
        public string Marital_status { get; set; } //Married - Single - Separated - Free - Union - Divorced - Widowed

        public string Affiliation_regime { get; set; } //Subsidized - contributory
        public string EPS_IPS { get; set; }


        // background
        public string Tbc { get; set; }               //Absence   -   Family  - Personal
        public string Diabetes { get; set; }          //Absence   -   Family  - Personal
        public string Hypertension { get; set; }      //Absence   -   Family  - Personal
        public string Eclampsia { get; set; }         //Absence   -   Family  - Personal
        public string Preeclampsia { get; set; }      //Absence   -   Family  - Personal
        public string Surgery { get; set; }           //Absence   -   Family  - Personal
        public string Infertility { get; set; }       //Absence   -   Family  - Personal
        public string Cardiopathy { get; set; }       //Absence   -   Family  - Personal
        public string Nephropathy { get; set; }       //Absence   -   Family  - Personal
        public string Violence { get; set; }          //Absence   -   Family  - Personal
        public string HIV { get; set; }               //Absence   -   Family  - Personal
        public string Migraine { get; set; }          //Absence   -   Family  - Personal
        public string Thromboembolic { get; set; }//Absence   -   Family  - Personal
        public string BMI_29 { get; set; }             //Absence   -   Family  - Personal
        public string BMI_39 { get; set; }             //Absence   -   Family  - Personal
        public string Disc_Sang { get; set; }          //Absence   -   Family  - Personal
        public string Other { get; set; }       //Absence   -   Family  - Personal
        public int PatientID { get; set; }

        //ChronologyPregnancy
        public int ReliableFUM { get; set; }
        public int UltrasoundObstetrics { get; set; }
        public int FPP { get; set; }
        public int FPC { get; set; }
        public DateTime ProbableDateOfDelivery { get; set; }
        public DateTime ProbableDateOfConception { get; set; }

        //Immunizations

        public string TetanusDiphtheriaNo { get; set; }
        public string TetanusDiphtheriaYesPrevPreg { get; set; }
        public string TetanusDiphtheriaYesDuringPreg { get; set; }

        public DateTime TetanusDiphtheria_Date { get; set; }
        public int TetanusDiphtheria_Dozes { get; set; }



        public string TdapNo { get; set; }
        public string TdapYesPrevPreg { get; set; }
        public string TdapYesDuringPreg { get; set; }
        public DateTime Tdap_Date { get; set; }
        public int Tdap_Dozes { get; set; }

        public string InfluenzaNo { get; set; }
        public string InfluenzaYesPrevPreg { get; set; }
        public string InfluenzaYesDuringPreg { get; set; }
        public DateTime Influenza_Date { get; set; }
        public int Influenza_Dozes { get; set; }

        public string RubellaNo { get; set; }
        public string RubellaYesPrevPreg { get; set; }
        public string RubellaYesDuringPreg { get; set; }
        public DateTime Rubella_Date { get; set; }
        public int Rubella_Dozes { get; set; }

        public string Hepatitis_ANo { get; set; }
        public string Hepatitis_AYesPrevPreg { get; set; }
        public string Hepatitis_AYesDuringPreg { get; set; }
        public DateTime Hepatitis_A_Date { get; set; }
        public int Hepatitis_A_Dozes { get; set; }

        public string Hepatitis_BNo { get; set; }
        public string Hepatitis_BYesPrevPreg { get; set; }
        public string Hepatitis_BYesDuringPreg { get; set; }
        public DateTime Hepatitis_B_Date { get; set; }
        public int Hepatitis_B_Dozes { get; set; }


        //LaboratoryTests
        public string GroupPositve { get; set; }
        public string SanguineoGroup { get; set; }
        public string GroupNegative { get; set; }
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
        public int Gestation { get; set; }
        public int NoOfPregnancy { get; set; }
        public int Delivery { get; set; }
        public int Term { get; set; }
        public int Preterm { get; set; }
        public int Vaginal { get; set; }
        public int Cesareas { get; set; }
        public int Abortions { get; set; }
        public int Gemerales { get; set; }
        public int Ectopic { get; set; }
        public int Obitus { get; set; }
        public int Molas { get; set; }
        public int Live_Births { get; set; }
        //PregnancyConfirmation
        public DateTime FUM { get; set; }
        public string WeeksPregnant { get; set; }
        public string Positive_HCG_presence { get; set; }
        public DateTime Positive_HCG_presence_Date { get; set; }
        public string Upload_document1 { get; set; }
        public string Positive_TV_ultrasound { get; set; }
        public DateTime Positive_TV_ultrasound_Date { get; set; }
        public string Upload_document2 { get; set; }
        public string PregnancyConfirm { get; set; } //Yes or No


        //PsychosocialAssessment
        public string SmokerActive { get; set; }
        public string PassiveSmoking { get; set; }
        public string ConsumeAlcohol { get; set; }
        public string ConsumeAlucinogenos { get; set; }
        public string DomesticViolence { get; set; }

    }
}