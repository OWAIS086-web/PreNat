using Microsoft.AspNet.Identity;
using Microsoft.Office.Interop.Word;
using PreNat.Entities;
using PreNat.Services;
using PreNat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PreNat.Controllers
{
    public class PatientMasterController : Controller
    {
        // GET: PatientMaster
        public ActionResult Index(string SearchTerm = "")
        {
            MainListingViewModel model = new MainListingViewModel();
            if (User.IsInRole("Admin"))
            {
                model.PatientMasters = PatientMasterServices.Instance.GetPatientMasters(SearchTerm);
            }
            else
            {
                model.PatientMasters = PatientMasterServices.Instance.GetPatientMasters(User.Identity.GetUserId(), SearchTerm);

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
                model.ID = patientmaster.ID;
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
                model.TetanusCheck = patientmaster.TetanusCheck;

                model.TdapNo = patientmaster.TdapNo;
                model.TdapYesPrevPreg = patientmaster.TdapYesPrevPreg;
                model.TdapYesDuringPreg = patientmaster.TdapYesDuringPreg;
                model.Tdap_Date = patientmaster.Tdap_Date;
                model.Tdap_Dozes = patientmaster.Tdap_Dozes;
                model.TdapCheck = patientmaster.TdapCheck;

                model.InfluenzaNo = patientmaster.InfluenzaNo;
                model.InfluenzaYesPrevPreg = patientmaster.InfluenzaYesPrevPreg;
                model.InfluenzaYesDuringPreg = patientmaster.InfluenzaYesDuringPreg;
                model.Influenza_Date = patientmaster.Influenza_Date;
                model.Influenza_Dozes = patientmaster.Influenza_Dozes;
                model.InfluencaCheck = patientmaster.InfluencaCheck;

                model.RubellaNo = patientmaster.RubellaNo;
                model.RubellaYesPrevPreg = patientmaster.RubellaYesPrevPreg;
                model.RubellaYesDuringPreg = patientmaster.RubellaYesDuringPreg;
                model.Rubella_Date = patientmaster.Rubella_Date;
                model.Rubella_Dozes = patientmaster.Rubella_Dozes;
                model.RubellaCheck = patientmaster.RubellaCheck;

                model.Hepatitis_ANo = patientmaster.Hepatitis_ANo;
                model.Hepatitis_AYesPrevPreg = patientmaster.Hepatitis_AYesPrevPreg;
                model.Hepatitis_AYesDuringPreg = patientmaster.Hepatitis_AYesDuringPreg;
                model.Hepatitis_A_Date = patientmaster.Hepatitis_A_Date;
                model.Hepatitis_A_Dozes = patientmaster.Hepatitis_A_Dozes;
                model.Hepatitis_ACheck = patientmaster.Hepatitis_ACheck;

                model.Hepatitis_BNo = patientmaster.Hepatitis_BNo;
                model.Hepatitis_BYesPrevPreg = patientmaster.Hepatitis_BYesPrevPreg;
                model.Hepatitis_BYesDuringPreg = patientmaster.Hepatitis_BYesDuringPreg;
                model.Hepatitis_B_Date = patientmaster.Hepatitis_B_Date;
                model.Hepatitis_B_Dozes = patientmaster.Hepatitis_B_Dozes;
                model.Hepatitis_BCheck = patientmaster.Hepatitis_BCheck;

                model.Group = patientmaster.Group;
                model.SanguineoGroup = patientmaster.SanguineoGroup;
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
                model.GestationalFormula=patientmaster.GestationalFormula;
                model.ReportStatus = patientmaster.ReportStatus;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Action(MainActionViewModel model, string Step)
        {
            if (Session["PatientMasterID"] != null)
            {
                var patientmaster = PatientMasterServices.Instance.GetPatientMaster(int.Parse(Session["PatientMasterID"].ToString()));
                patientmaster.ID = patientmaster.ID;
                patientmaster.CreatedBy = User.Identity.GetUserId();
                if (Step == "Step1")
                {
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
                }
                if (Step == "Step2")
                {
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
                }
                if (Step == "Step3")
                {
                    
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
                }
                if (Step == "Step4")
                {
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
                    patientmaster.GestationalFormula = model.GestationalFormula;
                }
                if (Step == "Step5")
                {
                    patientmaster.PlannedPregnancy = model.PlannedPregnancy;
                    patientmaster.DesiredPregnancy = model.DesiredPregnancy;
                    patientmaster.PreconceptionCounseling = model.PreconceptionCounseling;
                    patientmaster.ContraceptiveFailure = model.ContraceptiveFailure;
                    patientmaster.DefinitiveMethod = model.DefinitiveMethod;
                    patientmaster.Failure = model.Failure;
                }
                if (Step == "Step6")
                {
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
                }
                if (Step == "Step7")
                {

                    patientmaster.SmokerActive = model.SmokerActive;
                    patientmaster.PassiveSmoking = model.PassiveSmoking;
                    patientmaster.ConsumeAlcohol = model.ConsumeAlcohol;
                    patientmaster.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                    patientmaster.DomesticViolence = model.DomesticViolence;

                }
                if (Step == "Step8")
                {
                    patientmaster.TetanusCheck = model.TetanusCheck;
                    patientmaster.TdapCheck = model.TdapCheck;
                    patientmaster.InfluencaCheck = model.InfluencaCheck;
                    patientmaster.RubellaCheck = model.RubellaCheck;
                    patientmaster.Hepatitis_ACheck = model.Hepatitis_ACheck;
                    patientmaster.Hepatitis_BCheck = model.Hepatitis_BCheck;
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
                }
                if (Step == "Step9")
                {
                    patientmaster.Group = model.Group;
                    patientmaster.SanguineoGroup = model.SanguineoGroup;
                    patientmaster.VDRL = model.VDRL;
                    patientmaster.Syphilis = model.Syphilis;
                    patientmaster.VIH_L = model.VIH_L;
                    #region ModerateRegion



                    #region VariableRegion
                    var TBC = new List<string>();
                    if (patientmaster.Tbc != null)
                    {
                        TBC = patientmaster.Tbc.Trim().Split(',').ToList();
                    }

                    var Diabetes = new List<string>();
                    if (patientmaster.Diabetes != null)
                    {
                        Diabetes = patientmaster.Diabetes.Trim().Split(',').ToList();
                    }

                    var Migraine = new List<string>();
                    if (patientmaster.Migraine != null)
                    {
                        Migraine = patientmaster.Migraine.Trim().Split(',').ToList();
                    }

                    var Hypertension = new List<string>();
                    if (patientmaster.Hypertension != null)
                    {
                        Hypertension = patientmaster.Hypertension.Trim().Split(',').ToList();
                    }

                    var Eclampsia = new List<string>();
                    if (patientmaster.Eclampsia != null)
                    {
                        Eclampsia = patientmaster.Eclampsia.Trim().Split(',').ToList();
                    }


                    var Preeclampsia = new List<string>();
                    if (patientmaster.Preeclampsia != null)
                    {
                        Preeclampsia = patientmaster.Preeclampsia.Trim().Split(',').ToList();
                    }

                    var Surgery = new List<string>();
                    if (patientmaster.Surgery != null)
                    {
                        Surgery = patientmaster.Surgery.Trim().Split(',').ToList();
                    }


                    var Cardiopathy = new List<string>();
                    if (patientmaster.Cardiopathy != null)
                    {
                        Cardiopathy = patientmaster.Cardiopathy.Trim().Split(',').ToList();
                    }


                    var HIV = new List<string>();
                    if (patientmaster.HIV != null)
                    {
                        HIV = patientmaster.HIV.Trim().Split(',').ToList();
                    }

                    var Thromboembolic = new List<string>();
                    if (patientmaster.Thromboembolic != null)
                    {
                        Thromboembolic = patientmaster.Thromboembolic.Trim().Split(',').ToList();
                    }

                    var BMI29 = new List<string>();
                    if (patientmaster.BMI_29 != null)
                    {
                        BMI29 = patientmaster.BMI_29.Trim().Split(',').ToList();
                    }


                    var BMI39 = new List<string>();
                    if (patientmaster.BMI_39 != null)
                    {
                        HIV = patientmaster.BMI_39.Trim().Split(',').ToList();
                    }


                    var Infertility = new List<string>();
                    if (patientmaster.Infertility != null)
                    {
                        Infertility = patientmaster.Infertility.Trim().Split(',').ToList();
                    }

                    var Nephropathy = new List<string>();
                    if (patientmaster.Nephropathy != null)
                    {
                        Nephropathy = patientmaster.Nephropathy.Trim().Split(',').ToList();
                    }

                    var Violence = new List<string>();
                    if (patientmaster.Violence != null)
                    {
                        Violence = patientmaster.Violence.Trim().Split(',').ToList();
                    }

                    var Disc_Sang = new List<string>();
                    if (patientmaster.Disc_Sang != null)
                    {
                        Disc_Sang = patientmaster.Disc_Sang.Trim().Split(',').ToList();
                    }

                    #endregion
                    
                    if (patientmaster.Age > 35 || patientmaster.Age < 15
                    || patientmaster.Race_DANE_Information == "Indigenous"
                    || patientmaster.Ethnicity_DANE_Information == "Indigenous"
                    || patientmaster.Ethnicity_DANE_Information == "Gypsy"
                    || TBC.Contains("Family") == true
                    || Diabetes.Contains("Family") == true
                    || Migraine.Contains("Family") == true
                    || Hypertension.Contains("Family") == true
                    || Eclampsia.Contains("Family") == true
                    || Preeclampsia.Contains("Family") == true
                    || Surgery.Contains("Family") == true
                    || Cardiopathy.Contains("Family") == true
                    || Infertility.Contains("Family") == true
                    || Nephropathy.Contains("Family") == true
                    || Violence.Contains("Family") == true
                    || HIV.Contains("Family") == true
                    || Thromboembolic.Contains("Family") == true
                    || BMI29.Contains("Family") == true
                    || BMI39.Contains("Family") == true
                    || Disc_Sang.Contains("Family") == true
                    || Surgery.Contains("Personally") == true
                    || Migraine.Contains("Personally") == true
                    || BMI29.Contains("Personally") == true
                    || patientmaster.Preterm > 0
                    || patientmaster.Cesareas > 0
                    || patientmaster.Abortions > 0
                    || patientmaster.Gemerales > 0
                    || patientmaster.Ectopic > 0
                    || patientmaster.Obitus > 0
                    || patientmaster.Molas > 0
                    || patientmaster.PlannedPregnancy == "No"
                    || patientmaster.DesiredPregnancy == "No"
                    || patientmaster.PreconceptionCounseling == "No"
                    || patientmaster.ContraceptiveFailure == "No"
                    || patientmaster.Failure == "No"
                    || patientmaster.DefinitiveMethod == "No"
                    || patientmaster.SmokerActive == "Yes"
                    || patientmaster.PassiveSmoking == "Yes"
                    || patientmaster.ConsumeAlcohol == "Yes"
                    || patientmaster.ConsumeAlucinogenos == "Yes"
                    || patientmaster.TetanusDiphtheriaNo == "Yes"
                    || patientmaster.InfluenzaNo == "Yes"
                    || patientmaster.RubellaNo == "Yes"
                    || patientmaster.Hepatitis_ANo == "Yes"
                    || patientmaster.Hepatitis_BNo == "Yes"
                    || patientmaster.TdapNo == "Yes"
                    || patientmaster.Group == "AB"
                    || patientmaster.Group == "O"
                    || patientmaster.VDRL == "Positive"
                    || patientmaster.Syphilis == "Positive"
                    || patientmaster.HIV == "Positive")
                    {
                        patientmaster.ReportStatus = "Moderate";
                    }

                    #endregion

                    #region HighRegion

                    else if (TBC.Contains("Personally") == true
                        || Diabetes.Contains("Personally") == true
                        || Hypertension.Contains("Personally") == true
                        || Eclampsia.Contains("Personally") == true
                        || Preeclampsia.Contains("Personally") == true
                        || Infertility.Contains("Personally") == true
                        || Cardiopathy.Contains("Personally") == true
                        || Nephropathy.Contains("Personally") == true
                        || Violence.Contains("Personally") == true
                        || HIV.Contains("Personally") == true
                        || Thromboembolic.Contains("Personally") == true
                        || BMI39.Contains("Personally") == true
                        || Disc_Sang.Contains("Personally") == true

                        || patientmaster.DomesticViolence == "Yes")
                    {
                        patientmaster.ReportStatus = "High";
                    }
                    else
                    {
                        patientmaster.ReportStatus = "Low";

                    }

                    #endregion
                }


                PatientMasterServices.Instance.UpdatePatientMasters(patientmaster);
            }
            else
            {
                if (model.ID != 0)
                {
                    var patientmaster = PatientMasterServices.Instance.GetPatientMaster(model.ID);
                    patientmaster.ID = model.ID;
                    patientmaster.CreatedBy = User.Identity.GetUserId();
                    if (Step == "Step1")
                    {
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
                    } 
                    if (Step == "Step2")
                    {
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
                    }
                    if (Step == "Step3")
                    {
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
                    }
                    if (Step == "Step4")
                    {
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
                        patientmaster.GestationalFormula = model.GestationalFormula;

                    }
                    if (Step == "Step5")
                    {
                        patientmaster.PlannedPregnancy = model.PlannedPregnancy;
                        patientmaster.DesiredPregnancy = model.DesiredPregnancy;
                        patientmaster.PreconceptionCounseling = model.PreconceptionCounseling;
                        patientmaster.ContraceptiveFailure = model.ContraceptiveFailure;
                        patientmaster.DefinitiveMethod = model.DefinitiveMethod;
                        patientmaster.Failure = model.Failure;
                    }
                    if (Step == "Step6")
                    {
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
                    }
                    if (Step == "Step7")
                    {

                        patientmaster.SmokerActive = model.SmokerActive;
                        patientmaster.PassiveSmoking = model.PassiveSmoking;
                        patientmaster.ConsumeAlcohol = model.ConsumeAlcohol;
                        patientmaster.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                        patientmaster.DomesticViolence = model.DomesticViolence;
                    }
                    if (Step == "Step8")
                    {
                        patientmaster.TetanusCheck = model.TetanusCheck;
                        patientmaster.TdapCheck = model.TdapCheck;
                        patientmaster.InfluencaCheck = model.InfluencaCheck;
                        patientmaster.RubellaCheck = model.RubellaCheck;
                        patientmaster.Hepatitis_ACheck = model.Hepatitis_ACheck;
                        patientmaster.Hepatitis_BCheck = model.Hepatitis_BCheck;
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
                    }
                    if (Step == "Step9")
                    {
                        patientmaster.SanguineoGroup = model.SanguineoGroup;
                        patientmaster.Group = model.Group;
                        patientmaster.VDRL = model.VDRL;
                        patientmaster.Syphilis = model.Syphilis;
                        patientmaster.VIH_L = model.VIH_L;

                        #region ModerateRegion



                        #region VariableRegion
                        var TBC = new List<string>();
                        if (patientmaster.Tbc != null)
                        {
                            TBC = patientmaster.Tbc.Trim().Split(',').ToList();
                        }

                        var Diabetes = new List<string>();
                        if (patientmaster.Diabetes != null)
                        {
                            Diabetes = patientmaster.Diabetes.Trim().Split(',').ToList();
                        }

                        var Migraine = new List<string>();
                        if (patientmaster.Migraine != null)
                        {
                            Migraine = patientmaster.Migraine.Trim().Split(',').ToList();
                        }

                        var Hypertension = new List<string>();
                        if (patientmaster.Hypertension != null)
                        {
                            Hypertension = patientmaster.Hypertension.Trim().Split(',').ToList();
                        }

                        var Eclampsia = new List<string>();
                        if (patientmaster.Eclampsia != null)
                        {
                            Eclampsia = patientmaster.Eclampsia.Trim().Split(',').ToList();
                        }


                        var Preeclampsia = new List<string>();
                        if (patientmaster.Preeclampsia != null)
                        {
                            Preeclampsia = patientmaster.Preeclampsia.Trim().Split(',').ToList();
                        }

                        var Surgery = new List<string>();
                        if (patientmaster.Surgery != null)
                        {
                            Surgery = patientmaster.Surgery.Trim().Split(',').ToList();
                        }


                        var Cardiopathy = new List<string>();
                        if (patientmaster.Cardiopathy != null)
                        {
                            Cardiopathy = patientmaster.Cardiopathy.Trim().Split(',').ToList();
                        }


                        var HIV = new List<string>();
                        if (patientmaster.HIV != null)
                        {
                            HIV = patientmaster.HIV.Trim().Split(',').ToList();
                        }

                        var Thromboembolic = new List<string>();
                        if (patientmaster.Thromboembolic != null)
                        {
                            Thromboembolic = patientmaster.Thromboembolic.Trim().Split(',').ToList();
                        }

                        var BMI29 = new List<string>();
                        if (patientmaster.BMI_29 != null)
                        {
                            BMI29 = patientmaster.BMI_29.Trim().Split(',').ToList();
                        }


                        var BMI39 = new List<string>();
                        if (patientmaster.BMI_39 != null)
                        {
                            HIV = patientmaster.BMI_39.Trim().Split(',').ToList();
                        }


                        var Infertility = new List<string>();
                        if (patientmaster.Infertility != null)
                        {
                            Infertility = patientmaster.Infertility.Trim().Split(',').ToList();
                        }

                        var Nephropathy = new List<string>();
                        if (patientmaster.Nephropathy != null)
                        {
                            Nephropathy = patientmaster.Nephropathy.Trim().Split(',').ToList();
                        }

                        var Violence = new List<string>();
                        if (patientmaster.Violence != null)
                        {
                            Violence = patientmaster.Violence.Trim().Split(',').ToList();
                        }

                        var Disc_Sang = new List<string>();
                        if (patientmaster.Disc_Sang != null)
                        {
                            Disc_Sang = patientmaster.Disc_Sang.Trim().Split(',').ToList();
                        }

                        #endregion
                        if (patientmaster.Age > 35 || patientmaster.Age < 15
                        || patientmaster.Race_DANE_Information == "Indigenous"
                        || patientmaster.Ethnicity_DANE_Information == "Indigenous"
                        || patientmaster.Ethnicity_DANE_Information == "Gypsy"
                        || TBC.Contains("Family") == true
                        || Diabetes.Contains("Family") == true
                        || Migraine.Contains("Family") == true
                        || Hypertension.Contains("Family") == true
                        || Eclampsia.Contains("Family") == true
                        || Preeclampsia.Contains("Family") == true
                        || Surgery.Contains("Family") == true
                        || Cardiopathy.Contains("Family") == true
                        || Infertility.Contains("Family") == true
                        || Nephropathy.Contains("Family") == true
                        || Violence.Contains("Family") == true
                        || HIV.Contains("Family") == true
                        || Thromboembolic.Contains("Family") == true
                        || BMI29.Contains("Family") == true
                        || BMI39.Contains("Family") == true
                        || Disc_Sang.Contains("Family") == true
                        || Surgery.Contains("Personally") == true
                        || Migraine.Contains("Personally") == true
                        || BMI29.Contains("Personally") == true
                        || patientmaster.Preterm > 0
                        || patientmaster.Cesareas > 0
                        || patientmaster.Abortions > 0
                        || patientmaster.Gemerales > 0
                        || patientmaster.Ectopic > 0
                        || patientmaster.Obitus > 0
                        || patientmaster.Molas > 0
                        || patientmaster.PlannedPregnancy == "No"
                        || patientmaster.DesiredPregnancy == "No"
                        || patientmaster.PreconceptionCounseling == "No"
                        || patientmaster.ContraceptiveFailure == "No"
                        || patientmaster.Failure == "No"
                        || patientmaster.DefinitiveMethod == "No"
                        || patientmaster.SmokerActive == "Yes"
                        || patientmaster.PassiveSmoking == "Yes"
                        || patientmaster.ConsumeAlcohol == "Yes"
                        || patientmaster.ConsumeAlucinogenos == "Yes"
                        || patientmaster.TetanusDiphtheriaNo == "No"
                        || patientmaster.InfluenzaNo == "No"
                        || patientmaster.RubellaNo == "No"
                        || patientmaster.Hepatitis_ANo == "No"
                        || patientmaster.Hepatitis_BNo == "No"
                        || patientmaster.TdapNo == "No"
                        || patientmaster.Group == "AB"
                        || patientmaster.Group == "O"
                        || patientmaster.VDRL == "Positive"
                        || patientmaster.Syphilis == "Positive"
                        || patientmaster.HIV == "Positive")
                        {
                            patientmaster.ReportStatus = "Moderate";
                        }

                        #endregion

                        #region HighRegion

                        if (TBC.Contains("Personally") == true
                            || Diabetes.Contains("Personally") == true
                            || Hypertension.Contains("Personally") == true
                            || Eclampsia.Contains("Personally") == true
                            || Preeclampsia.Contains("Personally") == true
                            || Infertility.Contains("Personally") == true
                            || Cardiopathy.Contains("Personally") == true
                            || Nephropathy.Contains("Personally") == true
                            || Violence.Contains("Personally") == true
                            || HIV.Contains("Personally") == true
                            || Thromboembolic.Contains("Personally") == true
                            || BMI39.Contains("Personally") == true
                            || Disc_Sang.Contains("Personally") == true
                           
                            || patientmaster.DomesticViolence == "Yes")
                        {
                            patientmaster.ReportStatus = "High";
                        }
                        #endregion
                    }
                    PatientMasterServices.Instance.UpdatePatientMasters(patientmaster);
                }
                else
                {

                    //First Time Save
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


                    #region OnlyDateOnes
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
                   

                    if (model.TetanusDiphtheria_Date.Year == 1)
                    {
                        patientmaster.TetanusDiphtheria_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;

                    }
                 
                    if (model.Tdap_Date.Year == 1)
                    {
                        patientmaster.Tdap_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Tdap_Date = model.Tdap_Date;

                    }
                
                    if (model.Influenza_Date.Year == 1)
                    {
                        patientmaster.Influenza_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Influenza_Date = model.Influenza_Date;

                    }
       
                    if (model.Rubella_Date.Year == 1)
                    {
                        patientmaster.Rubella_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Rubella_Date = model.Rubella_Date;

                    }
                  
                    if (model.Hepatitis_A_Date.Year == 1)
                    {
                        patientmaster.Hepatitis_A_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Hepatitis_A_Date = model.Hepatitis_A_Date;

                    }
          

                    if (model.Hepatitis_B_Date.Year == 1)
                    {
                        patientmaster.Hepatitis_B_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Hepatitis_B_Date = model.Hepatitis_B_Date;

                    }

                    if (model.FUM.Year == 1)
                    {
                        patientmaster.FUM = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.FUM = model.FUM;

                    }


                    if (model.Positive_HCG_presence_Date.Year == 1)
                    {
                        patientmaster.Positive_HCG_presence_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Positive_HCG_presence_Date = model.Positive_HCG_presence_Date;

                    }


                    if (model.Positive_TV_ultrasound_Date.Year == 1)
                    {
                        patientmaster.Positive_TV_ultrasound_Date = DateTime.Now;
                    }
                    else
                    {
                        patientmaster.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;

                    }
                    #endregion
                    PatientMasterServices.Instance.SavePatientMasters(patientmaster);
                    Session["PatientMasterID"] = patientmaster.ID;
                }
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