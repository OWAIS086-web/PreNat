using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class ImmunizationsController : Controller
    {
        // GET: Immunizations



        public ActionResult Index(string SearchTerm = "")
        {
            ImmunizationsListingViewModel model = new ImmunizationsListingViewModel();
            model.Immunizationss = ImmunizationsServices.Instance.GetImmunizationss(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ImmunizationsActionViewModel model = new ImmunizationsActionViewModel();
            if (ID != 0)
            {


                var Immunizations = ImmunizationsServices.Instance.GetImmunizations(ID);
                model.ID = Immunizations.ID;
                model.TetanusDiphtheriaNo = Immunizations.TetanusDiphtheriaNo;
                model.TetanusDiphtheriaYesPrevPreg = Immunizations.TetanusDiphtheriaYesPrevPreg;
                model.TetanusDiphtheriaYesDuringPreg = Immunizations.TetanusDiphtheriaYesDuringPreg;
                model.TetanusDiphtheria_Date = Immunizations.TetanusDiphtheria_Date;
                model.TetanusDiphtheria_Dozes = Immunizations.TetanusDiphtheria_Dozes;
                model.TdapNo = Immunizations.TdapNo;
                model.TdapYesPrevPreg = Immunizations.TdapYesPrevPreg;
                model.TdapYesDuringPreg = Immunizations.TdapYesDuringPreg;
                model.Tdap_Date = Immunizations.Tdap_Date;
                model.Tdap_Dozes = Immunizations.Tdap_Dozes;
                model.InfluenzaNo = Immunizations.InfluenzaNo;
                model.InfluenzaYesPrevPreg = Immunizations.InfluenzaYesPrevPreg;
                model.InfluenzaYesDuringPreg = Immunizations.InfluenzaYesDuringPreg;
                model.Influenza_Date = Immunizations.Influenza_Date;
                model.Influenza_Dozes = Immunizations.Influenza_Dozes;
                model.RubellaNo = Immunizations.RubellaNo;
                model.RubellaYesPrevPreg = Immunizations.RubellaYesPrevPreg;
                model.RubellaYesDuringPreg = Immunizations.RubellaYesDuringPreg;
                model.Rubella_Date = Immunizations.Rubella_Date;
                model.Rubella_Dozes = Immunizations.Rubella_Dozes;
                model.Hepatitis_ANo = Immunizations.Hepatitis_ANo;
                model.Hepatitis_AYesPrevPreg = Immunizations.Hepatitis_AYesPrevPreg;
                model.Hepatitis_AYesDuringPreg = Immunizations.Hepatitis_AYesDuringPreg;
                model.Hepatitis_A_Date = Immunizations.Hepatitis_A_Date;
                model.Hepatitis_A_Dozes = Immunizations.Hepatitis_A_Dozes;
                model.Hepatitis_BNo = Immunizations.Hepatitis_BNo;
                model.Hepatitis_BYesPrevPreg = Immunizations.Hepatitis_BYesPrevPreg;
                model.Hepatitis_BYesDuringPreg = Immunizations.Hepatitis_BYesDuringPreg;
                model.Hepatitis_B_Date = Immunizations.Hepatitis_B_Date;
                model.Hepatitis_B_Dozes = Immunizations.Hepatitis_B_Dozes;


            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            ImmunizationsActionViewModel model = new ImmunizationsActionViewModel();
            var Immunizations = ImmunizationsServices.Instance.GetImmunizations(ID);
            model.ID = Immunizations.ID;
            model.TetanusDiphtheriaNo = Immunizations.TetanusDiphtheriaNo;
            model.TetanusDiphtheriaYesPrevPreg = Immunizations.TetanusDiphtheriaYesPrevPreg;
            model.TetanusDiphtheriaYesDuringPreg = Immunizations.TetanusDiphtheriaYesDuringPreg;
            model.TetanusDiphtheria_Date = Immunizations.TetanusDiphtheria_Date;
            model.TetanusDiphtheria_Dozes = Immunizations.TetanusDiphtheria_Dozes;
            model.TdapNo = Immunizations.TdapNo;
            model.TdapYesPrevPreg = Immunizations.TdapYesPrevPreg;
            model.TdapYesDuringPreg = Immunizations.TdapYesDuringPreg;
            model.Tdap_Date = Immunizations.Tdap_Date;
            model.Tdap_Dozes = Immunizations.Tdap_Dozes;
            model.InfluenzaNo = Immunizations.InfluenzaNo;
            model.InfluenzaYesPrevPreg = Immunizations.InfluenzaYesPrevPreg;
            model.InfluenzaYesDuringPreg = Immunizations.InfluenzaYesDuringPreg;
            model.Influenza_Date = Immunizations.Influenza_Date;
            model.Influenza_Dozes = Immunizations.Influenza_Dozes;
            model.RubellaNo = Immunizations.RubellaNo;
            model.RubellaYesPrevPreg = Immunizations.RubellaYesPrevPreg;
            model.RubellaYesDuringPreg = Immunizations.RubellaYesDuringPreg;
            model.Rubella_Date = Immunizations.Rubella_Date;
            model.Rubella_Dozes = Immunizations.Rubella_Dozes;
            model.Hepatitis_ANo = Immunizations.Hepatitis_ANo;
            model.Hepatitis_AYesPrevPreg = Immunizations.Hepatitis_AYesPrevPreg;
            model.Hepatitis_AYesDuringPreg = Immunizations.Hepatitis_AYesDuringPreg;
            model.Hepatitis_A_Date = Immunizations.Hepatitis_A_Date;
            model.Hepatitis_A_Dozes = Immunizations.Hepatitis_A_Dozes;
            model.Hepatitis_BNo = Immunizations.Hepatitis_BNo;
            model.Hepatitis_BYesPrevPreg = Immunizations.Hepatitis_BYesPrevPreg;
            model.Hepatitis_BYesDuringPreg = Immunizations.Hepatitis_BYesDuringPreg;
            model.Hepatitis_B_Date = Immunizations.Hepatitis_B_Date;
            model.Hepatitis_B_Dozes = Immunizations.Hepatitis_B_Dozes;


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(ImmunizationsActionViewModel model)
        {
            if (model.ID != 0)
            {
                var immunizations = ImmunizationsServices.Instance.GetImmunizations(model.ID);

                immunizations.ID = model.ID;
                immunizations.TetanusDiphtheriaNo = model.TetanusDiphtheriaNo;
                immunizations.TetanusDiphtheriaYesPrevPreg = model.TetanusDiphtheriaYesPrevPreg;
                immunizations.TetanusDiphtheriaYesDuringPreg = model.TetanusDiphtheriaYesDuringPreg;
                immunizations.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;
                immunizations.TetanusDiphtheria_Dozes = model.TetanusDiphtheria_Dozes;
                immunizations.TdapNo = model.TdapNo;
                immunizations.TdapYesPrevPreg = model.TdapYesPrevPreg;
                immunizations.TdapYesDuringPreg = model.TdapYesDuringPreg;
                immunizations.Tdap_Date = model.Tdap_Date;
                immunizations.Tdap_Dozes = model.Tdap_Dozes;
                immunizations.InfluenzaNo = model.InfluenzaNo;
                immunizations.InfluenzaYesPrevPreg = model.InfluenzaYesPrevPreg;
                immunizations.InfluenzaYesDuringPreg = model.InfluenzaYesDuringPreg;
                immunizations.Influenza_Date = model.Influenza_Date;
                immunizations.Influenza_Dozes = model.Influenza_Dozes;
                immunizations.RubellaNo = model.RubellaNo;
                immunizations.RubellaYesPrevPreg = model.RubellaYesPrevPreg;
                immunizations.RubellaYesDuringPreg = model.RubellaYesDuringPreg;
                immunizations.Rubella_Date = model.Rubella_Date;
                immunizations.Rubella_Dozes = model.Rubella_Dozes;
                immunizations.Hepatitis_ANo = model.Hepatitis_ANo;
                immunizations.Hepatitis_AYesPrevPreg = model.Hepatitis_AYesPrevPreg;
                immunizations.Hepatitis_AYesDuringPreg = model.Hepatitis_AYesDuringPreg;
                immunizations.Hepatitis_A_Date = model.Hepatitis_A_Date;
                immunizations.Hepatitis_A_Dozes = model.Hepatitis_A_Dozes;
                immunizations.Hepatitis_BNo = model.Hepatitis_BNo;
                immunizations.Hepatitis_BYesPrevPreg = model.Hepatitis_BYesPrevPreg;
                immunizations.Hepatitis_BYesDuringPreg = model.Hepatitis_BYesDuringPreg;
                immunizations.Hepatitis_B_Date = model.Hepatitis_B_Date;
                immunizations.Hepatitis_B_Dozes = model.Hepatitis_B_Dozes;

                ImmunizationsServices.Instance.UpdateImmunizationss(immunizations);


            }
            else
            {
                var immunizations = new Immunizations();
                immunizations.TetanusDiphtheriaNo = model.TetanusDiphtheriaNo;
                immunizations.TetanusDiphtheriaYesPrevPreg = model.TetanusDiphtheriaYesPrevPreg;
                immunizations.TetanusDiphtheriaYesDuringPreg = model.TetanusDiphtheriaYesDuringPreg;
                immunizations.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;
                immunizations.TetanusDiphtheria_Dozes = model.TetanusDiphtheria_Dozes;
                immunizations.TdapNo = model.TdapNo;
                immunizations.TdapYesPrevPreg = model.TdapYesPrevPreg;
                immunizations.TdapYesDuringPreg = model.TdapYesDuringPreg;
                immunizations.Tdap_Date = model.Tdap_Date;
                immunizations.Tdap_Dozes = model.Tdap_Dozes;
                immunizations.InfluenzaNo = model.InfluenzaNo;
                immunizations.InfluenzaYesPrevPreg = model.InfluenzaYesPrevPreg;
                immunizations.InfluenzaYesDuringPreg = model.InfluenzaYesDuringPreg;
                immunizations.Influenza_Date = model.Influenza_Date;
                immunizations.Influenza_Dozes = model.Influenza_Dozes;
                immunizations.RubellaNo = model.RubellaNo;
                immunizations.RubellaYesPrevPreg = model.RubellaYesPrevPreg;
                immunizations.RubellaYesDuringPreg = model.RubellaYesDuringPreg;
                immunizations.Rubella_Date = model.Rubella_Date;
                immunizations.Rubella_Dozes = model.Rubella_Dozes;
                immunizations.Hepatitis_ANo = model.Hepatitis_ANo;
                immunizations.Hepatitis_AYesPrevPreg = model.Hepatitis_AYesPrevPreg;
                immunizations.Hepatitis_AYesDuringPreg = model.Hepatitis_AYesDuringPreg;
                immunizations.Hepatitis_A_Date = model.Hepatitis_A_Date;
                immunizations.Hepatitis_A_Dozes = model.Hepatitis_A_Dozes;
                immunizations.Hepatitis_BNo = model.Hepatitis_BNo;
                immunizations.Hepatitis_BYesPrevPreg = model.Hepatitis_BYesPrevPreg;
                immunizations.Hepatitis_BYesDuringPreg = model.Hepatitis_BYesDuringPreg;
                immunizations.Hepatitis_B_Date = model.Hepatitis_B_Date;
                immunizations.Hepatitis_B_Dozes = model.Hepatitis_B_Dozes;

                ImmunizationsServices.Instance.SaveImmunizationss(immunizations);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ImmunizationsActionViewModel model = new ImmunizationsActionViewModel();

            var Immunizations = ImmunizationsServices.Instance.GetImmunizations(ID);
            model.ID = Immunizations.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(ImmunizationsActionViewModel model)
        {

            ImmunizationsServices.Instance.DeleteImmunizationss(model.ID);









            return Json(new { success = true });
        }
    }
}

