using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class PsychosocialAssessmentController : Controller
    {
        // GET: PsychosocialAssessment



        public ActionResult Index(string SearchTerm = "")
        {
            PsychosocialAssessmentListingViewModel model = new PsychosocialAssessmentListingViewModel();
            model.PsychosocialAssessments = PsychosocialAssessmentServices.Instance.GetPsychosocialAssessments(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            PsychosocialAssessmentActionViewModel model = new PsychosocialAssessmentActionViewModel();
            if (ID != 0)
            {


                var PsychosocialAssessment = PsychosocialAssessmentServices.Instance.GetPsychosocialAssessment(ID);
                model.ID = PsychosocialAssessment.ID;
                model.SmokerActive = PsychosocialAssessment.SmokerActive;
                model.PassiveSmoking = PsychosocialAssessment.PassiveSmoking;
                model.ConsumeAlcohol = PsychosocialAssessment.ConsumeAlcohol;
                model.ConsumeAlucinogenos = PsychosocialAssessment.ConsumeAlucinogenos;
                model.DomesticViolence = PsychosocialAssessment.DomesticViolence;
               

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            PsychosocialAssessmentActionViewModel model = new PsychosocialAssessmentActionViewModel();
            var PsychosocialAssessment = PsychosocialAssessmentServices.Instance.GetPsychosocialAssessment(ID);
            model.SmokerActive = PsychosocialAssessment.SmokerActive;
            model.PassiveSmoking = PsychosocialAssessment.PassiveSmoking;
            model.ConsumeAlcohol = PsychosocialAssessment.ConsumeAlcohol;
            model.ConsumeAlucinogenos = PsychosocialAssessment.ConsumeAlucinogenos;
            model.DomesticViolence = PsychosocialAssessment.DomesticViolence;
      

            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(PsychosocialAssessmentActionViewModel model)
        {
            if (model.ID != 0)
            {
                var PsychosocialAssessment = PsychosocialAssessmentServices.Instance.GetPsychosocialAssessment(model.ID);

                PsychosocialAssessment.ID = model.ID;
                PsychosocialAssessment.SmokerActive = model.SmokerActive;
                PsychosocialAssessment.PassiveSmoking = model.PassiveSmoking;
                PsychosocialAssessment.ConsumeAlcohol = model.ConsumeAlcohol;
                PsychosocialAssessment.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                PsychosocialAssessment.DomesticViolence = model.DomesticViolence;
    
                PsychosocialAssessmentServices.Instance.UpdatePsychosocialAssessments(PsychosocialAssessment);


            }
            else
            {
                var PsychosocialAssessment = new PsychosocialAssessment();
                PsychosocialAssessment.SmokerActive = model.SmokerActive;
                PsychosocialAssessment.PassiveSmoking = model.PassiveSmoking;
                PsychosocialAssessment.ConsumeAlcohol = model.ConsumeAlcohol;
                PsychosocialAssessment.ConsumeAlucinogenos = model.ConsumeAlucinogenos;
                PsychosocialAssessment.DomesticViolence = model.DomesticViolence;
               

                PsychosocialAssessmentServices.Instance.SavePsychosocialAssessments(PsychosocialAssessment);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            PsychosocialAssessmentActionViewModel model = new PsychosocialAssessmentActionViewModel();

            var PsychosocialAssessment = PsychosocialAssessmentServices.Instance.GetPsychosocialAssessment(ID);
            model.ID = PsychosocialAssessment.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(PsychosocialAssessmentActionViewModel model)
        {

            PsychosocialAssessmentServices.Instance.DeletePsychosocialAssessments(model.ID);









            return Json(new { success = true });
        }
    }
}

