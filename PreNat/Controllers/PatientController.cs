using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient



        public ActionResult Index(string SearchTerm = "")
        {
            PatientListingViewModel model = new PatientListingViewModel();
            model.Patients = PatientServices.Instance.GetPatients(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            PatientActionViewModel model = new PatientActionViewModel();
            if (ID != 0)
            {


                var Patient = PatientServices.Instance.GetPatient(ID);
                model.ID = Patient.ID;
                model.Name = Patient.Name;
                model.Surnames = Patient.Surnames;
                model.Type_of_Identity = Patient.Type_of_Identity;
                model.Department_of_residence = Patient.Department_of_residence;
                model.City_Municipality_of_residence = Patient.City_Municipality_of_residence;
                model.Address_of_residence = Patient.Address_of_residence;
                model.Telephones_Landline = Patient.Telephones_Landline;
                model.Cell_Phone = Patient.Cell_Phone;
                model.Date_of_birth = Patient.Date_of_birth;
                model.Age = Patient.Age;
                model.Race_DANE_Information = Patient.Race_DANE_Information;
                model.Ethnicity_DANE_Information = Patient.Ethnicity_DANE_Information;
                model.Level_of_Education = Patient.Level_of_Education;
                model.Marital_status = Patient.Marital_status;
                model.Affiliation_regime = Patient.Affiliation_regime;
                model.EPS_IPS = Patient.EPS_IPS;

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            PatientActionViewModel model = new PatientActionViewModel();
            var Patient = PatientServices.Instance.GetPatient(ID);
            model.Name = Patient.Name;
            model.Surnames = Patient.Surnames;
            model.Type_of_Identity = Patient.Type_of_Identity;
            model.Department_of_residence = Patient.Department_of_residence;
            model.City_Municipality_of_residence = Patient.City_Municipality_of_residence;
            model.Address_of_residence = Patient.Address_of_residence;
            model.Telephones_Landline = Patient.Telephones_Landline;
            model.Cell_Phone = Patient.Cell_Phone;
            model.Date_of_birth = Patient.Date_of_birth;
            model.Age = Patient.Age;
            model.Race_DANE_Information = Patient.Race_DANE_Information;
            model.Ethnicity_DANE_Information = Patient.Ethnicity_DANE_Information;
            model.Level_of_Education = Patient.Level_of_Education;
            model.Marital_status = Patient.Marital_status;
            model.Affiliation_regime = Patient.Affiliation_regime;
            model.EPS_IPS = Patient.EPS_IPS;


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(PatientActionViewModel model)
        {
            if (model.ID != 0)
            {
                var patient = PatientServices.Instance.GetPatient(model.ID);

                patient.ID = model.ID;
                patient.Name = model.Name;
                patient.Surnames = model.Surnames;
                patient.Type_of_Identity = model.Type_of_Identity;
                patient.Department_of_residence = model.Department_of_residence;
                patient.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patient.Address_of_residence = model.Address_of_residence;
                patient.Telephones_Landline = model.Telephones_Landline;
                patient.Cell_Phone = model.Cell_Phone;
                patient.Date_of_birth = model.Date_of_birth;
                patient.Age = model.Age;
                patient.Race_DANE_Information = model.Race_DANE_Information;
                patient.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patient.Level_of_Education = model.Level_of_Education;
                patient.Marital_status = model.Marital_status;
                patient.Affiliation_regime = model.Affiliation_regime;
                patient.EPS_IPS = model.EPS_IPS;

                PatientServices.Instance.UpdatePatients(patient);

            
            }
            else
            {
                var patient = new Patient();
                patient.Name = model.Name;
                patient.Surnames = model.Surnames;
                patient.Type_of_Identity = model.Type_of_Identity;
                patient.Department_of_residence = model.Department_of_residence;
                patient.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patient.Address_of_residence = model.Address_of_residence;
                patient.Telephones_Landline = model.Telephones_Landline;
                patient.Cell_Phone = model.Cell_Phone;
                patient.Date_of_birth = model.Date_of_birth;
                patient.Age = model.Age;
                patient.Race_DANE_Information = model.Race_DANE_Information;
                patient.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patient.Level_of_Education = model.Level_of_Education;
                patient.Marital_status = model.Marital_status;
                patient.Affiliation_regime = model.Affiliation_regime;
                patient.EPS_IPS = model.EPS_IPS;

                PatientServices.Instance.SavePatients(patient);

              
            }
            return Json(new { success = true });
        }




        public ActionResult MainAction(MainActionViewModel model)
        {

            if (Session["PatientID"] != null)
            {
                var patient = PatientServices.Instance.GetPatient(int.Parse(Session["PatientID"].ToString()));
                patient.Name = model.Name;
                patient.Surnames = model.Surnames;
                patient.Type_of_Identity = model.Type_of_Identity;
                patient.Department_of_residence = model.Department_of_residence;
                patient.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patient.Address_of_residence = model.Address_of_residence;
                patient.Telephones_Landline = model.Telephones_Landline;
                patient.Cell_Phone = model.Cell_Phone;
                patient.Date_of_birth = model.Date_of_birth;
                patient.Age = model.Age;
                patient.Race_DANE_Information = model.Race_DANE_Information;
                patient.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patient.Level_of_Education = model.Level_of_Education;
                patient.Marital_status = model.Marital_status;
                patient.Affiliation_regime = model.Affiliation_regime;
                patient.EPS_IPS = model.EPS_IPS;

                PatientServices.Instance.UpdatePatients(patient);
                Session["PatientID"] = patient.ID;
                return Json(new { success = true, PatientID = patient.ID });
            }
            else
            {
                var patient = new Patient();
                patient.Name = model.Name;
                patient.Surnames = model.Surnames;
                patient.Type_of_Identity = model.Type_of_Identity;
                patient.Department_of_residence = model.Department_of_residence;
                patient.City_Municipality_of_residence = model.City_Municipality_of_residence;
                patient.Address_of_residence = model.Address_of_residence;
                patient.Telephones_Landline = model.Telephones_Landline;
                patient.Cell_Phone = model.Cell_Phone;
                patient.Date_of_birth = model.Date_of_birth;
                patient.Age = model.Age;
                patient.Race_DANE_Information = model.Race_DANE_Information;
                patient.Ethnicity_DANE_Information = model.Ethnicity_DANE_Information;
                patient.Level_of_Education = model.Level_of_Education;
                patient.Marital_status = model.Marital_status;
                patient.Affiliation_regime = model.Affiliation_regime;
                patient.EPS_IPS = model.EPS_IPS;

                PatientServices.Instance.SavePatients(patient);
                Session["PatientID"] = patient.ID;
                return Json(new { success = true, PatientID = patient.ID });
            }

        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            PatientActionViewModel model = new PatientActionViewModel();

            var Patient = PatientServices.Instance.GetPatient(ID);
            model.ID = Patient.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(PatientActionViewModel model)
        {

            PatientServices.Instance.DeletePatients(model.ID);
            return Json(new { success = true });
        }
    }
}

