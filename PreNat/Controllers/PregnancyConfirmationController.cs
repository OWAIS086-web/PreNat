using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class PregnancyConfirmationController : Controller
    {
        // GET: PregnancyConfirmation



        public ActionResult Index(string SearchTerm = "")
        {
            PregnancyConfirmationListingViewModel model = new PregnancyConfirmationListingViewModel();
            model.PregnancyConfirmations = PregnancyConfirmationServices.Instance.GetPregnancyConfirmations(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            PregnancyConfirmationActionViewModel model = new PregnancyConfirmationActionViewModel();
            if (ID != 0)
            {


                var PregnancyConfirmation = PregnancyConfirmationServices.Instance.GetPregnancyConfirmation(ID);
                model.ID = PregnancyConfirmation.ID;
                model.FUM = PregnancyConfirmation.FUM;
                model.FUM_Date = PregnancyConfirmation.FUM_Date;
                model.Positive_HCG_presence = PregnancyConfirmation.Positive_HCG_presence;
                model.Positive_HCG_presence_Date = PregnancyConfirmation.Positive_HCG_presence_Date;
                model.Upload_document1 = PregnancyConfirmation.Upload_document1;
                model.Positive_TV_ultrasound = PregnancyConfirmation.Positive_TV_ultrasound;
                model.Positive_TV_ultrasound_Date = PregnancyConfirmation.Positive_TV_ultrasound_Date;
                model.Upload_document2 = PregnancyConfirmation.Upload_document2;
                model.PregnancyConfirm = PregnancyConfirmation.PregnancyConfirm;
               

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            PregnancyConfirmationActionViewModel model = new PregnancyConfirmationActionViewModel();
            var PregnancyConfirmation = PregnancyConfirmationServices.Instance.GetPregnancyConfirmation(ID);
            model.FUM = PregnancyConfirmation.FUM;
            model.FUM_Date = PregnancyConfirmation.FUM_Date;
            model.Positive_HCG_presence = PregnancyConfirmation.Positive_HCG_presence;
            model.Positive_HCG_presence_Date = PregnancyConfirmation.Positive_HCG_presence_Date;
            model.Upload_document1 = PregnancyConfirmation.Upload_document1;
            model.Positive_TV_ultrasound = PregnancyConfirmation.Positive_TV_ultrasound;
            model.Positive_TV_ultrasound_Date = PregnancyConfirmation.Positive_TV_ultrasound_Date;
            model.Upload_document2 = PregnancyConfirmation.Upload_document2;
            model.PregnancyConfirm = PregnancyConfirmation.PregnancyConfirm;
   


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(PregnancyConfirmationActionViewModel model)
        {
            if (model.ID != 0)
            {
                var PregnancyConfirmation = PregnancyConfirmationServices.Instance.GetPregnancyConfirmation(model.ID);

                PregnancyConfirmation.ID = model.ID;
                PregnancyConfirmation.FUM = model.FUM;
                PregnancyConfirmation.FUM_Date = model.FUM_Date;
                PregnancyConfirmation.Positive_HCG_presence = model.Positive_HCG_presence;
                PregnancyConfirmation.Positive_HCG_presence_Date = model.Positive_HCG_presence_Date;
                PregnancyConfirmation.Upload_document1 = model.Upload_document1;
                PregnancyConfirmation.Positive_TV_ultrasound = model.Positive_TV_ultrasound;
                PregnancyConfirmation.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;
                PregnancyConfirmation.Upload_document2 = model.Upload_document2;
                PregnancyConfirmation.PregnancyConfirm = model.PregnancyConfirm;


                PregnancyConfirmationServices.Instance.UpdatePregnancyConfirmations(PregnancyConfirmation);


            }
            else
            {
                var PregnancyConfirmation = new PregnancyConfirmation();
                PregnancyConfirmation.FUM = model.FUM;
                PregnancyConfirmation.FUM_Date = model.FUM_Date;
                PregnancyConfirmation.Positive_HCG_presence = model.Positive_HCG_presence;
                PregnancyConfirmation.Positive_HCG_presence_Date = model.Positive_HCG_presence_Date;
                PregnancyConfirmation.Upload_document1 = model.Upload_document1;
                PregnancyConfirmation.Positive_TV_ultrasound = model.Positive_TV_ultrasound;
                PregnancyConfirmation.Positive_TV_ultrasound_Date = model.Positive_TV_ultrasound_Date;
                PregnancyConfirmation.Upload_document2 = model.Upload_document2;
                PregnancyConfirmation.PregnancyConfirm = model.PregnancyConfirm;


                PregnancyConfirmationServices.Instance.SavePregnancyConfirmations(PregnancyConfirmation);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            PregnancyConfirmationActionViewModel model = new PregnancyConfirmationActionViewModel();

            var PregnancyConfirmation = PregnancyConfirmationServices.Instance.GetPregnancyConfirmation(ID);
            model.ID = PregnancyConfirmation.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(PregnancyConfirmationActionViewModel model)
        {

            PregnancyConfirmationServices.Instance.DeletePregnancyConfirmations(model.ID);









            return Json(new { success = true });
        }
    }
}

