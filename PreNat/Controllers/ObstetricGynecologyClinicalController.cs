using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class ObstetricGynecologyClinicalController : Controller
    {
        // GET: ObstetricGynecologyClinical



        public ActionResult Index(string SearchTerm = "")
        {
            ObstetricGynecologyClinicalListingViewModel model = new ObstetricGynecologyClinicalListingViewModel();
            model.ObstetricGynecologyClinicals = ObstetricGynecologyClinicalServices.Instance.GetObstetricGynecologyClinicals(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ObstetricGynecologyClinicalActionViewModel model = new ObstetricGynecologyClinicalActionViewModel();
            if (ID != 0)
            {


                var ObstetricGynecologyClinical = ObstetricGynecologyClinicalServices.Instance.GetObstetricGynecologyClinical(ID);
                model.ID = ObstetricGynecologyClinical.ID;
                model.PlannedPregnancy = ObstetricGynecologyClinical.PlannedPregnancy;
                model.DesiredPregnancy = ObstetricGynecologyClinical.DesiredPregnancy;
                model.PreconceptionCounseling = ObstetricGynecologyClinical.PreconceptionCounseling;
                model.ContraceptiveFailure = ObstetricGynecologyClinical.ContraceptiveFailure;
                model.DefinitiveMethod = ObstetricGynecologyClinical.DefinitiveMethod;
                model.Failure = ObstetricGynecologyClinical.Failure;


            }
            return PartialView("_Action", model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            ObstetricGynecologyClinicalActionViewModel model = new ObstetricGynecologyClinicalActionViewModel();
            var ObstetricGynecologyClinical = ObstetricGynecologyClinicalServices.Instance.GetObstetricGynecologyClinical(ID);
            model.PlannedPregnancy = ObstetricGynecologyClinical.PlannedPregnancy;
            model.DesiredPregnancy = ObstetricGynecologyClinical.DesiredPregnancy;
            model.PreconceptionCounseling = ObstetricGynecologyClinical.PreconceptionCounseling;
            model.ContraceptiveFailure = ObstetricGynecologyClinical.ContraceptiveFailure;
            model.DefinitiveMethod = ObstetricGynecologyClinical.DefinitiveMethod;
            model.Failure = ObstetricGynecologyClinical.Failure;
          


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(ObstetricGynecologyClinicalActionViewModel model)
        {
            if (model.ID != 0)
            {
                var ObstetricGynecologyClinical = ObstetricGynecologyClinicalServices.Instance.GetObstetricGynecologyClinical(model.ID);

                ObstetricGynecologyClinical.ID = model.ID;
                ObstetricGynecologyClinical.PlannedPregnancy = model.PlannedPregnancy;
                ObstetricGynecologyClinical.DesiredPregnancy = model.DesiredPregnancy;
                ObstetricGynecologyClinical.PreconceptionCounseling = model.PreconceptionCounseling;
                ObstetricGynecologyClinical.ContraceptiveFailure = model.ContraceptiveFailure;
                ObstetricGynecologyClinical.DefinitiveMethod = model.DefinitiveMethod;
                ObstetricGynecologyClinical.Failure = model.Failure;


                ObstetricGynecologyClinicalServices.Instance.UpdateObstetricGynecologyClinicals(ObstetricGynecologyClinical);


            }
            else
            {
                var ObstetricGynecologyClinical = new ObstetricGynecologyClinical();
                ObstetricGynecologyClinical.PlannedPregnancy = model.PlannedPregnancy;
                ObstetricGynecologyClinical.DesiredPregnancy = model.DesiredPregnancy;
                ObstetricGynecologyClinical.PreconceptionCounseling = model.PreconceptionCounseling;
                ObstetricGynecologyClinical.ContraceptiveFailure = model.ContraceptiveFailure;
                ObstetricGynecologyClinical.DefinitiveMethod = model.DefinitiveMethod;
                ObstetricGynecologyClinical.Failure = model.Failure;

                ObstetricGynecologyClinicalServices.Instance.SaveObstetricGynecologyClinicals(ObstetricGynecologyClinical);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ObstetricGynecologyClinicalActionViewModel model = new ObstetricGynecologyClinicalActionViewModel();

            var ObstetricGynecologyClinical = ObstetricGynecologyClinicalServices.Instance.GetObstetricGynecologyClinical(ID);
            model.ID = ObstetricGynecologyClinical.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(ObstetricGynecologyClinicalActionViewModel model)
        {

            ObstetricGynecologyClinicalServices.Instance.DeleteObstetricGynecologyClinicals(model.ID);









            return Json(new { success = true });
        }
    }
}

