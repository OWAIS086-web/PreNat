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
                model.TetanusDiphtheria = Immunizations.TetanusDiphtheria;
                model.TetanusDiphtheria_Date = Immunizations.TetanusDiphtheria_Date;
                model.TetanusDiphtheria_Quantity = Immunizations.TetanusDiphtheria_Quantity;
                model.TDAP = Immunizations.TDAP;
                model.TDAP_Date = Immunizations.TDAP_Date;
                model.TDAP_Quantity = Immunizations.TDAP_Quantity;
                model.Influenza = Immunizations.Influenza;
                model.Influenza_Date = Immunizations.Influenza_Date;
                model.Influenza_Quantity = Immunizations.Influenza_Quantity;
                model.Rubella = Immunizations.Rubella;
                model.Rubella_Date = Immunizations.Rubella_Date;
                model.Rubella_Quantity = Immunizations.Rubella_Quantity;
                model.Hepatitis_B = Immunizations.Hepatitis_B;
                model.Hepatitis_B_Date = Immunizations.Hepatitis_B_Date;
                model.Hepatitis_B_Quantity = Immunizations.Hepatitis_B_Quantity;
                model.Hepatitis_A = Immunizations.Hepatitis_A;
                model.Hepatitis_A_Date = Immunizations.Hepatitis_A_Date;
                model.Hepatitis_A_Quantity = Immunizations.Hepatitis_A_Quantity;


            }
            return PartialView("_Action", model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            ImmunizationsActionViewModel model = new ImmunizationsActionViewModel();
            var Immunizations = ImmunizationsServices.Instance.GetImmunizations(ID);
            model.TetanusDiphtheria = Immunizations.TetanusDiphtheria;
            model.TetanusDiphtheria_Date = Immunizations.TetanusDiphtheria_Date;
            model.TetanusDiphtheria_Quantity = Immunizations.TetanusDiphtheria_Quantity;
            model.TDAP = Immunizations.TDAP;
            model.TDAP_Date = Immunizations.TDAP_Date;
            model.TDAP_Quantity = Immunizations.TDAP_Quantity;
            model.Influenza = Immunizations.Influenza;
            model.Influenza_Date = Immunizations.Influenza_Date;
            model.Influenza_Quantity = Immunizations.Influenza_Quantity;
            model.Rubella = Immunizations.Rubella;
            model.Rubella_Date = Immunizations.Rubella_Date;
            model.Rubella_Quantity = Immunizations.Rubella_Quantity;
            model.Hepatitis_B = Immunizations.Hepatitis_B;
            model.Hepatitis_B_Date = Immunizations.Hepatitis_B_Date;
            model.Hepatitis_B_Quantity = Immunizations.Hepatitis_B_Quantity;
            model.Hepatitis_A = Immunizations.Hepatitis_A;
            model.Hepatitis_A_Date = Immunizations.Hepatitis_A_Date;
            model.Hepatitis_A_Quantity = Immunizations.Hepatitis_A_Quantity;


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(ImmunizationsActionViewModel model)
        {
            if (model.ID != 0)
            {
                var Immunizations = ImmunizationsServices.Instance.GetImmunizations(model.ID);

                Immunizations.ID = model.ID;
                Immunizations.TetanusDiphtheria = model.TetanusDiphtheria;
                Immunizations.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;
                Immunizations.TetanusDiphtheria_Quantity = model.TetanusDiphtheria_Quantity;
                Immunizations.TDAP = model.TDAP;
                Immunizations.TDAP_Date = model.TDAP_Date;
                Immunizations.TDAP_Quantity = model.TDAP_Quantity;
                Immunizations.Influenza = model.Influenza;
                Immunizations.Influenza_Date = model.Influenza_Date;
                Immunizations.Influenza_Quantity = model.Influenza_Quantity;
                Immunizations.Rubella = model.Rubella;
                Immunizations.Rubella_Date = model.Rubella_Date;
                Immunizations.Rubella_Quantity = model.Rubella_Quantity;
                Immunizations.Hepatitis_B = model.Hepatitis_B;
                Immunizations.Hepatitis_B_Date = model.Hepatitis_B_Date;
                Immunizations.Hepatitis_B_Quantity = model.Hepatitis_B_Quantity;
                Immunizations.Hepatitis_A = model.Hepatitis_A;
                Immunizations.Hepatitis_A_Date = model.Hepatitis_A_Date;
                Immunizations.Hepatitis_A_Quantity = model.Hepatitis_A_Quantity;

                ImmunizationsServices.Instance.UpdateImmunizationss(Immunizations);


            }
            else
            {
                var Immunizations = new Immunizations();
                Immunizations.TetanusDiphtheria = model.TetanusDiphtheria;
                Immunizations.TetanusDiphtheria_Date = model.TetanusDiphtheria_Date;
                Immunizations.TetanusDiphtheria_Quantity = model.TetanusDiphtheria_Quantity;
                Immunizations.TDAP = model.TDAP;
                Immunizations.TDAP_Date = model.TDAP_Date;
                Immunizations.TDAP_Quantity = model.TDAP_Quantity;
                Immunizations.Influenza = model.Influenza;
                Immunizations.Influenza_Date = model.Influenza_Date;
                Immunizations.Influenza_Quantity = model.Influenza_Quantity;
                Immunizations.Rubella = model.Rubella;
                Immunizations.Rubella_Date = model.Rubella_Date;
                Immunizations.Rubella_Quantity = model.Rubella_Quantity;
                Immunizations.Hepatitis_B = model.Hepatitis_B;
                Immunizations.Hepatitis_B_Date = model.Hepatitis_B_Date;
                Immunizations.Hepatitis_B_Quantity = model.Hepatitis_B_Quantity;
                Immunizations.Hepatitis_A = model.Hepatitis_A;
                Immunizations.Hepatitis_A_Date = model.Hepatitis_A_Date;
                Immunizations.Hepatitis_A_Quantity = model.Hepatitis_A_Quantity;

                ImmunizationsServices.Instance.SaveImmunizationss(Immunizations);


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

