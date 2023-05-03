using Microsoft.AspNet.Identity;
using PreNat.Entities;
using PreNat.Services;
using PreNat.ViewModels;
using System;
using System.Web.Mvc;

namespace PreNat.Controllers
{
    public class PatientMasterController : Controller
    {
        // GET: PatientMaster
        public ActionResult Index(string SearchTerm)
        {
            MainListingViewModel model = new MainListingViewModel();
            if (User.IsInRole("Admin"))
            {
                model.PatientMasters = PatientMasterServices.Instance.GetPatientMasters(SearchTerm);
            }
            else
            {
                model.PatientMasters = PatientMasterServices.Instance.GetPatientMasters(User.Identity.GetUserId(),SearchTerm);

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            MainActionViewModel model = new MainActionViewModel();
            if (ID != 0)
            {
                var patientmaster = PatientMasterServices.Instance.GetPatientMaster(ID);
                model.Name = patientmaster.Name;
                model.Surnames = patientmaster.Surnames;
                model.Type_of_Identity = patientmaster.Type_of_Identity;
                model.Department_of_residence = patientmaster.Department_of_residence;
                model.City_Municipality_of_residence = patientmaster.City_Municipality_of_residence;
                model.Address_of_residence = patientmaster.Address_of_residence;
                model.Telephones_Landline = patientmaster.Telephones_Landline;
                model.Cell_Phone = patientmaster.Cell_Phone;
                model.Date_of_birth = patientmaster.Date_of_birth;
                model.Age = patientmaster.Age;
                model.Race_DANE_Information = patientmaster.Race_DANE_Information;
                model.Ethnicity_DANE_Information = patientmaster.Ethnicity_DANE_Information;
                model.Level_of_Education = patientmaster.Level_of_Education;
                model.Marital_status = patientmaster.Marital_status;
                model.Affiliation_regime = patientmaster.Affiliation_regime;
                model.EPS_IPS = patientmaster.EPS_IPS;
                model.Tbc = patientmaster.Tbc;
                model.Diabetes = patientmaster.Diabetes;
                model.Hypertension = patientmaster.Hypertension;
                model.Eclampsia = patientmaster.Eclampsia;
                model.Preeclampsia = patientmaster.Preeclampsia;
                model.Surgery = patientmaster.Surgery;
                model.Infertility = patientmaster.Infertility;
                model.Cardiopathy = patientmaster.Cardiopathy;
                model.Nephropathy = patientmaster.Nephropathy;
                model.Violence = patientmaster.Violence;
                model.HIV = patientmaster.HIV;
                model.Migraine = patientmaster.Migraine;
                model.Thromboembolic = patientmaster.Thromboembolic;
                model.BMI_29 = patientmaster.BMI_29;
                model.BMI_39 = patientmaster.BMI_39;
                model.Disc_Sang = patientmaster.Disc_Sang;
                model.Other = patientmaster.Other;
                model.ReliableFUM = patientmaster.ReliableFUM;
                model.UltrasoundObstetrics = patientmaster.UltrasoundObstetrics;
                model.FPP = patientmaster.FPP;
                model.FPC = patientmaster.FPC;
                model.ProbableDateOfDelivery = patientmaster.ProbableDateOfDelivery;
                model.ProbableDateOfConception = patientmaster.ProbableDateOfConception;
                model.TetanusDiphtheriaNo = patientmaster.TetanusDiphtheriaNo;
                model.TetanusDiphtheriaYesPrevPreg = patientmaster.TetanusDiphtheriaYesPrevPreg;
                model.TetanusDiphtheriaYesDuringPreg = patientmaster.TetanusDiphtheriaYesDuringPreg;
                model.TetanusDiphtheria_Date = patientmaster.TetanusDiphtheria_Date;
                model.TetanusDiphtheria_Dozes = patientmaster.TetanusDiphtheria_Dozes;
                model.TdapNo = patientmaster.TdapNo;
                model.TdapYesPrevPreg = patientmaster.TdapYesPrevPreg;
                model.TdapYesDuringPreg = patientmaster.TdapYesDuringPreg;
                model.Tdap_Date = patientmaster.Tdap_Date;
                model.Tdap_Dozes = patientmaster.Tdap_Dozes;
                model.InfluenzaNo = patientmaster.InfluenzaNo;
                model.InfluenzaYesPrevPreg = patientmaster.InfluenzaYesPrevPreg;
                model.InfluenzaYesDuringPreg = patientmaster.InfluenzaYesDuringPreg;
                model.Influenza_Date = patientmaster.Influenza_Date;
                model.Influenza_Dozes = patientmaster.Influenza_Dozes;
                model.RubellaNo = patientmaster.RubellaNo;
                model.RubellaYesPrevPreg = patientmaster.RubellaYesPrevPreg;
                model.RubellaYesDuringPreg = patientmaster.RubellaYesDuringPreg;
                model.Rubella_Date = patientmaster.Rubella_Date;
                model.Rubella_Dozes = patientmaster.Rubella_Dozes;
                model.Hepatitis_ANo = patientmaster.Hepatitis_ANo;
                model.Hepatitis_AYesPrevPreg = patientmaster.Hepatitis_AYesPrevPreg;
                model.Hepatitis_AYesDuringPreg = patientmaster.Hepatitis_AYesDuringPreg;
                model.Hepatitis_A_Date = patientmaster.Hepatitis_A_Date;
                model.Hepatitis_A_Dozes = patientmaster.Hepatitis_A_Dozes;
                model.Hepatitis_BNo = patientmaster.Hepatitis_BNo;
                model.Hepatitis_BYesPrevPreg = patientmaster.Hepatitis_BYesPrevPreg;
                model.Hepatitis_BYesDuringPreg = patientmaster.Hepatitis_BYesDuringPreg;
                model.Hepatitis_B_Date = patientmaster.Hepatitis_B_Date;
                model.Hepatitis_B_Dozes = patientmaster.Hepatitis_B_Dozes;
                model.GroupPositve = patientmaster.GroupPositve;
                model.SanguineoGroup = patientmaster.SanguineoGroup;
                model.GroupNegative = patientmaster.GroupNegative;
                model.VDRL = patientmaster.VDRL;
                model.Syphilis = patientmaster.Syphilis;
                model.VIH_L = patientmaster.VIH_L;
                model.PlannedPregnancy = patientmaster.PlannedPregnancy;
                model.DesiredPregnancy = patientmaster.DesiredPregnancy;
                model.PreconceptionCounseling = patientmaster.PreconceptionCounseling;
                model.ContraceptiveFailure = patientmaster.ContraceptiveFailure;
                model.DefinitiveMethod = patientmaster.DefinitiveMethod;
                model.Failure = patientmaster.Failure;
                model.Gestation = patientmaster.Gestation;
                model.NoOfPregnancy = patientmaster.NoOfPregnancy;
                model.Delivery = patientmaster.Delivery;
                model.Term = patientmaster.Term;
                model.Preterm = patientmaster.Preterm;
                model.Vaginal = patientmaster.Vaginal;
                model.Cesareas = patientmaster.Cesareas;
                model.Abortions = patientmaster.Abortions;
                model.Gemerales = patientmaster.Gemerales;
                model.Ectopic = patientmaster.Ectopic;
                model.Obitus = patientmaster.Obitus;
                model.Molas = patientmaster.Molas;
                model.Live_Births = patientmaster.Live_Births;
                model.FUM = patientmaster.FUM;
                model.WeeksPregnant = patientmaster.WeeksPregnant;
                model.Positive_HCG_presence = patientmaster.Positive_HCG_presence;
                model.Positive_HCG_presence_Date = patientmaster.Positive_HCG_presence_Date;
                model.Upload_document1 = patientmaster.Upload_document1;
                model.Positive_TV_ultrasound = patientmaster.Positive_TV_ultrasound;
                model.Positive_TV_ultrasound_Date = patientmaster.Positive_TV_ultrasound_Date;
                model.Upload_document2 = patientmaster.Upload_document2;
                model.PregnancyConfirm = patientmaster.PregnancyConfirm;
                model.SmokerActive = patientmaster.SmokerActive;
                model.PassiveSmoking = patientmaster.PassiveSmoking;
                model.ConsumeAlcohol = patientmaster.ConsumeAlcohol;
                model.ConsumeAlucinogenos = patientmaster.ConsumeAlucinogenos;
                model.DomesticViolence = patientmaster.DomesticViolence;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(MainActionViewModel model)
        {
            if(model.ID != 0)
            {
                var patientmaster = PatientMasterServices.Instance.GetPatientMaster(model.ID);
                patientmaster.ID = model.ID;
                patientmaster.CreatedBy = User.Identity.GetUserId();
                patientmaster.Name = model.Name;

                patientmaster.Surnames = model.Surnames;
                patientmaster.Type_of_Identity = model.Type_of_Identity;
                patientmaster.Department_of_residence = model.Department_of_residence;
                patientmaster.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patientmaster.Address_of_residence = model.Address_of_residence;
                patientmaster.Telephones_Landline = model.Telephones_Landline;
                patientmaster.Cell_Phone = model.Cell_Phone;
                if (model.Date_of_birth.Year == 1) {
                    patientmaster.Date_of_birth = DateTime.Now;
                    patientmaster.Age = 0;

                }
                else
                {
                    patientmaster.Date_of_birth = model.Date_of_birth;
                    patientmaster.Age = model.Age;

                }
                patientmaster.Race_DANE_Information = model.Race_DANE_Information;
                patientmaster.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patientmaster.Level_of_Education = model.Level_of_Education;
                patientmaster.Marital_status = model.Marital_status;
                patientmaster.Affiliation_regime = model.Affiliation_regime;
                patientmaster.EPS_IPS = model.EPS_IPS;
                patientmaster.Tbc = model.Tbc;
                patientmaster.Diabetes = model.Diabetes;
                patientmaster.Hypertension = model.Hypertension;
                patientmaster.Eclampsia = model.Eclampsia;
                patientmaster.Preeclampsia = model.Preeclampsia;
                patientmaster.Surgery = model.Surgery;
                patientmaster.Infertility = model.Infertility;
                patientmaster.Cardiopathy = model.Cardiopathy;
                patientmaster.Nephropathy = model.Nephropathy;
                patientmaster.Violence = model.Violence;
                patientmaster.HIV = model.HIV;
                patientmaster.Migraine = model.Migraine;
                patientmaster.Thromboembolic = model.Thromboembolic;
                patientmaster.BMI_29 = model.BMI_29;
                patientmaster.BMI_39 = model.BMI_39;
                patientmaster.Disc_Sang = model.Disc_Sang;
                patientmaster.Other = model.Other;
                patientmaster.ReliableFUM = model.ReliableFUM;
                patientmaster.UltrasoundObstetrics = model.UltrasoundObstetrics;
                patientmaster.FPP = model.FPP;
                patientmaster.FPC = model.FPC;
                if(model.ProbableDateOfDelivery.Year == 1)
                {
                    patientmaster.ProbableDateOfDelivery = DateTime.Now;
                }
                else
                {
                    patientmaster.ProbableDateOfDelivery = model.ProbableDateOfDelivery;

                }
                if (model.ProbableDateOfConception.Year == 1)
                {
                    patientmaster.ProbableDateOfConception = DateTime.Now;
                }
                else
                {
                    patientmaster.ProbableDateOfConception = model.ProbableDateOfConception;

                }
                patientmaster.TetanusDiphtheriaNo = model.TetanusDiphtheriaNo;
                patientmaster.TetanusDiphtheriaYesPrevPreg = model.TetanusDiphtheriaYesPrevPreg;
                patientmaster.TetanusDiphtheriaYesDuringPreg = model.TetanusDiphtheriaYesDuringPreg;

                if(model.TetanusDiphtheria_Date.Year == 1)
                {
                    patientmaster.TetanusDiphtheria_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;

                }
                patientmaster.TetanusDiphtheria_Dozes = model.TetanusDiphtheria_Dozes;
                patientmaster.TdapNo = model.TdapNo;
                patientmaster.TdapYesPrevPreg = model.TdapYesPrevPreg;
                patientmaster.TdapYesDuringPreg = model.TdapYesDuringPreg;
                if (model.Tdap_Date.Year == 1)
                {
                    patientmaster.Tdap_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Tdap_Date = model.Tdap_Date;

                }
                patientmaster.Tdap_Dozes = model.Tdap_Dozes;
                patientmaster.InfluenzaNo = model.InfluenzaNo;
                patientmaster.InfluenzaYesPrevPreg = model.InfluenzaYesPrevPreg;
                patientmaster.InfluenzaYesDuringPreg = model.InfluenzaYesDuringPreg;
                if (model.Influenza_Date.Year == 1)
                {
                    patientmaster.Influenza_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Influenza_Date = model.Influenza_Date;

                }
                patientmaster.Influenza_Dozes = model.Influenza_Dozes;
                patientmaster.RubellaNo = model.RubellaNo;
                patientmaster.RubellaYesPrevPreg = model.RubellaYesPrevPreg;
                patientmaster.RubellaYesDuringPreg = model.RubellaYesDuringPreg;
                patientmaster.Rubella_Date = model.Rubella_Date;
                if (model.Rubella_Date.Year == 1)
                {
                    patientmaster.Rubella_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Rubella_Date = model.Rubella_Date;

                }
                patientmaster.Rubella_Dozes = model.Rubella_Dozes;
                patientmaster.Hepatitis_ANo = model.Hepatitis_ANo;
                patientmaster.Hepatitis_AYesPrevPreg = model.Hepatitis_AYesPrevPreg;
                patientmaster.Hepatitis_AYesDuringPreg = model.Hepatitis_AYesDuringPreg;
                if (model.Hepatitis_A_Date.Year == 1)
                {
                    patientmaster.Hepatitis_A_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Hepatitis_A_Date = model.Hepatitis_A_Date;

                }
                patientmaster.Hepatitis_A_Dozes = model.Hepatitis_A_Dozes;
                patientmaster.Hepatitis_BNo = model.Hepatitis_BNo;
                patientmaster.Hepatitis_BYesPrevPreg = model.Hepatitis_BYesPrevPreg;
                patientmaster.Hepatitis_BYesDuringPreg = model.Hepatitis_BYesDuringPreg;

                if (model.Hepatitis_B_Date.Year == 1)
                {
                    patientmaster.Hepatitis_B_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Hepatitis_B_Date = model.Hepatitis_B_Date;

                }

                patientmaster.Hepatitis_B_Dozes = model.Hepatitis_B_Dozes;
                patientmaster.GroupPositve = model.GroupPositve;
                patientmaster.SanguineoGroup = model.SanguineoGroup;
                patientmaster.GroupNegative = model.GroupNegative;
                patientmaster.VDRL = model.VDRL;
                patientmaster.Syphilis = model.Syphilis;
                patientmaster.VIH_L = model.VIH_L;
                patientmaster.PlannedPregnancy = model.PlannedPregnancy;
                patientmaster.DesiredPregnancy = model.DesiredPregnancy;
                patientmaster.PreconceptionCounseling = model.PreconceptionCounseling;
                patientmaster.ContraceptiveFailure = model.ContraceptiveFailure;
                patientmaster.DefinitiveMethod = model.DefinitiveMethod;
                patientmaster.Failure = model.Failure;
                patientmaster.Gestation = model.Gestation;
                patientmaster.NoOfPregnancy = model.NoOfPregnancy;
                patientmaster.Delivery = model.Delivery;
                patientmaster.Term = model.Term;
                patientmaster.Preterm = model.Preterm;
                patientmaster.Vaginal = model.Vaginal;
                patientmaster.Cesareas = model.Cesareas;
                patientmaster.Abortions = model.Abortions;
                patientmaster.Gemerales = model.Gemerales;
                patientmaster.Ectopic = model.Ectopic;
                patientmaster.Obitus = model.Obitus;
                patientmaster.Molas = model.Molas;
                patientmaster.Live_Births = model.Live_Births;
                if (model.FUM.Year == 1)
                {
                    patientmaster.FUM = DateTime.Now;
                }
                else
                {
                    patientmaster.FUM = model.FUM;

                }


                patientmaster.WeeksPregnant = model.WeeksPregnant;
                patientmaster.Positive_HCG_presence = model.Positive_HCG_presence;
                if (model.Positive_HCG_presence_Date.Year == 1)
                {
                    patientmaster.Positive_HCG_presence_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Positive_HCG_presence_Date = model.Positive_HCG_presence_Date;

                }


                patientmaster.Upload_document1 = model.Upload_document1;
                patientmaster.Positive_TV_ultrasound = model.Positive_TV_ultrasound;
                patientmaster.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;
                if (model.Positive_TV_ultrasound_Date.Year == 1)
                {
                    patientmaster.Positive_TV_ultrasound_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;

                }

                patientmaster.Upload_document2 = model.Upload_document2;
                patientmaster.PregnancyConfirm = model.PregnancyConfirm;
                patientmaster.SmokerActive = model.SmokerActive;
                patientmaster.PassiveSmoking = model.PassiveSmoking;
                patientmaster.ConsumeAlcohol = model.ConsumeAlcohol;
                patientmaster.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                patientmaster.DomesticViolence = model.DomesticViolence;
                PatientMasterServices.Instance.UpdatePatientMasters(patientmaster);
            }
            else
            {
                var patientmaster = new PatientMaster();
                patientmaster.CreatedBy = User.Identity.GetUserId();
                patientmaster.Name = model.Name;

                patientmaster.Surnames = model.Surnames;
                patientmaster.Type_of_Identity = model.Type_of_Identity;
                patientmaster.Department_of_residence = model.Department_of_residence;
                patientmaster.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patientmaster.Address_of_residence = model.Address_of_residence;
                patientmaster.Telephones_Landline = model.Telephones_Landline;
                patientmaster.Cell_Phone = model.Cell_Phone;
                if (model.Date_of_birth.Year == 1)
                {
                    patientmaster.Date_of_birth = DateTime.Now;
                    patientmaster.Age = 0;

                }
                else
                {
                    patientmaster.Date_of_birth = model.Date_of_birth;
                    patientmaster.Age = model.Age;

                }
                patientmaster.Race_DANE_Information = model.Race_DANE_Information;
                patientmaster.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patientmaster.Level_of_Education = model.Level_of_Education;
                patientmaster.Marital_status = model.Marital_status;
                patientmaster.Affiliation_regime = model.Affiliation_regime;
                patientmaster.EPS_IPS = model.EPS_IPS;
                patientmaster.Tbc = model.Tbc;
                patientmaster.Diabetes = model.Diabetes;
                patientmaster.Hypertension = model.Hypertension;
                patientmaster.Eclampsia = model.Eclampsia;
                patientmaster.Preeclampsia = model.Preeclampsia;
                patientmaster.Surgery = model.Surgery;
                patientmaster.Infertility = model.Infertility;
                patientmaster.Cardiopathy = model.Cardiopathy;
                patientmaster.Nephropathy = model.Nephropathy;
                patientmaster.Violence = model.Violence;
                patientmaster.HIV = model.HIV;
                patientmaster.Migraine = model.Migraine;
                patientmaster.Thromboembolic = model.Thromboembolic;
                patientmaster.BMI_29 = model.BMI_29;
                patientmaster.BMI_39 = model.BMI_39;
                patientmaster.Disc_Sang = model.Disc_Sang;
                patientmaster.Other = model.Other;
                patientmaster.ReliableFUM = model.ReliableFUM;
                patientmaster.UltrasoundObstetrics = model.UltrasoundObstetrics;
                patientmaster.FPP = model.FPP;
                patientmaster.FPC = model.FPC;
                if (model.ProbableDateOfDelivery.Year == 1)
                {
                    patientmaster.ProbableDateOfDelivery = DateTime.Now;
                }
                else
                {
                    patientmaster.ProbableDateOfDelivery = model.ProbableDateOfDelivery;

                }
                if (model.ProbableDateOfConception.Year == 1)
                {
                    patientmaster.ProbableDateOfConception = DateTime.Now;
                }
                else
                {
                    patientmaster.ProbableDateOfConception = model.ProbableDateOfConception;

                }
                patientmaster.TetanusDiphtheriaNo = model.TetanusDiphtheriaNo;
                patientmaster.TetanusDiphtheriaYesPrevPreg = model.TetanusDiphtheriaYesPrevPreg;
                patientmaster.TetanusDiphtheriaYesDuringPreg = model.TetanusDiphtheriaYesDuringPreg;

                if (model.TetanusDiphtheria_Date.Year == 1)
                {
                    patientmaster.TetanusDiphtheria_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;

                }
                patientmaster.TetanusDiphtheria_Dozes = model.TetanusDiphtheria_Dozes;
                patientmaster.TdapNo = model.TdapNo;
                patientmaster.TdapYesPrevPreg = model.TdapYesPrevPreg;
                patientmaster.TdapYesDuringPreg = model.TdapYesDuringPreg;
                if (model.Tdap_Date.Year == 1)
                {
                    patientmaster.Tdap_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Tdap_Date = model.Tdap_Date;

                }
                patientmaster.Tdap_Dozes = model.Tdap_Dozes;
                patientmaster.InfluenzaNo = model.InfluenzaNo;
                patientmaster.InfluenzaYesPrevPreg = model.InfluenzaYesPrevPreg;
                patientmaster.InfluenzaYesDuringPreg = model.InfluenzaYesDuringPreg;
                if (model.Influenza_Date.Year == 1)
                {
                    patientmaster.Influenza_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Influenza_Date = model.Influenza_Date;

                }
                patientmaster.Influenza_Dozes = model.Influenza_Dozes;
                patientmaster.RubellaNo = model.RubellaNo;
                patientmaster.RubellaYesPrevPreg = model.RubellaYesPrevPreg;
                patientmaster.RubellaYesDuringPreg = model.RubellaYesDuringPreg;
                patientmaster.Rubella_Date = model.Rubella_Date;
                if (model.Rubella_Date.Year == 1)
                {
                    patientmaster.Rubella_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Rubella_Date = model.Rubella_Date;

                }
                patientmaster.Rubella_Dozes = model.Rubella_Dozes;
                patientmaster.Hepatitis_ANo = model.Hepatitis_ANo;
                patientmaster.Hepatitis_AYesPrevPreg = model.Hepatitis_AYesPrevPreg;
                patientmaster.Hepatitis_AYesDuringPreg = model.Hepatitis_AYesDuringPreg;
                if (model.Hepatitis_A_Date.Year == 1)
                {
                    patientmaster.Hepatitis_A_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Hepatitis_A_Date = model.Hepatitis_A_Date;

                }
                patientmaster.Hepatitis_A_Dozes = model.Hepatitis_A_Dozes;
                patientmaster.Hepatitis_BNo = model.Hepatitis_BNo;
                patientmaster.Hepatitis_BYesPrevPreg = model.Hepatitis_BYesPrevPreg;
                patientmaster.Hepatitis_BYesDuringPreg = model.Hepatitis_BYesDuringPreg;

                if (model.Hepatitis_B_Date.Year == 1)
                {
                    patientmaster.Hepatitis_B_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Hepatitis_B_Date = model.Hepatitis_B_Date;

                }

                patientmaster.Hepatitis_B_Dozes = model.Hepatitis_B_Dozes;
                patientmaster.GroupPositve = model.GroupPositve;
                patientmaster.SanguineoGroup = model.SanguineoGroup;
                patientmaster.GroupNegative = model.GroupNegative;
                patientmaster.VDRL = model.VDRL;
                patientmaster.Syphilis = model.Syphilis;
                patientmaster.VIH_L = model.VIH_L;
                patientmaster.PlannedPregnancy = model.PlannedPregnancy;
                patientmaster.DesiredPregnancy = model.DesiredPregnancy;
                patientmaster.PreconceptionCounseling = model.PreconceptionCounseling;
                patientmaster.ContraceptiveFailure = model.ContraceptiveFailure;
                patientmaster.DefinitiveMethod = model.DefinitiveMethod;
                patientmaster.Failure = model.Failure;
                patientmaster.Gestation = model.Gestation;
                patientmaster.NoOfPregnancy = model.NoOfPregnancy;
                patientmaster.Delivery = model.Delivery;
                patientmaster.Term = model.Term;
                patientmaster.Preterm = model.Preterm;
                patientmaster.Vaginal = model.Vaginal;
                patientmaster.Cesareas = model.Cesareas;
                patientmaster.Abortions = model.Abortions;
                patientmaster.Gemerales = model.Gemerales;
                patientmaster.Ectopic = model.Ectopic;
                patientmaster.Obitus = model.Obitus;
                patientmaster.Molas = model.Molas;
                patientmaster.Live_Births = model.Live_Births;
                if (model.FUM.Year == 1)
                {
                    patientmaster.FUM = DateTime.Now;
                }
                else
                {
                    patientmaster.FUM = model.FUM;

                }


                patientmaster.WeeksPregnant = model.WeeksPregnant;
                patientmaster.Positive_HCG_presence = model.Positive_HCG_presence;
                if (model.Positive_HCG_presence_Date.Year == 1)
                {
                    patientmaster.Positive_HCG_presence_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Positive_HCG_presence_Date = model.Positive_HCG_presence_Date;

                }


                patientmaster.Upload_document1 = model.Upload_document1;
                patientmaster.Positive_TV_ultrasound = model.Positive_TV_ultrasound;
                patientmaster.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;
                if (model.Positive_TV_ultrasound_Date.Year == 1)
                {
                    patientmaster.Positive_TV_ultrasound_Date = DateTime.Now;
                }
                else
                {
                    patientmaster.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;

                }

                patientmaster.Upload_document2 = model.Upload_document2;
                patientmaster.PregnancyConfirm = model.PregnancyConfirm;
                patientmaster.SmokerActive = model.SmokerActive;
                patientmaster.PassiveSmoking = model.PassiveSmoking;
                patientmaster.ConsumeAlcohol = model.ConsumeAlcohol;
                patientmaster.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                patientmaster.DomesticViolence = model.DomesticViolence;
                PatientMasterServices.Instance.SavePatientMasters(patientmaster);
            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            MainActionViewModel model = new MainActionViewModel();

            var PatientMaster = PatientMasterServices.Instance.GetPatientMaster(ID);
            model.ID = PatientMaster.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(MainActionViewModel model)
        {

            PatientMasterServices.Instance.DeletePatientMasters(model.ID);
            return Json(new { success = true });
        }



    }
}