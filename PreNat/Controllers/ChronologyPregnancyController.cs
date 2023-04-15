using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class ChronologyPregnancyController : Controller
    {
        // GET: ChronologyPregnancy



        public ActionResult Index(string SearchTerm = "")
        {
            ChronologyPregnancyListingViewModel model = new ChronologyPregnancyListingViewModel();
            model.ChronologyPregnancys = ChronologyPregnancyServices.Instance.GetChronologyPregnancys(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ChronologyPregnancyActionViewModel model = new ChronologyPregnancyActionViewModel();
            if (ID != 0)
            {


                var ChronologyPregnancy = ChronologyPregnancyServices.Instance.GetChronologyPregnancy(ID);
                model.ID = ChronologyPregnancy.ID;
                model.ReliableFUM = ChronologyPregnancy.ReliableFUM;
                model.UltrasoundObstetrics = ChronologyPregnancy.UltrasoundObstetrics;
                model.FPP = ChronologyPregnancy.FPP;
                model.FPC = ChronologyPregnancy.FPC;
               

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            ChronologyPregnancyActionViewModel model = new ChronologyPregnancyActionViewModel();
            var ChronologyPregnancy = ChronologyPregnancyServices.Instance.GetChronologyPregnancy(ID);
            model.ReliableFUM = ChronologyPregnancy.ReliableFUM;
            model.UltrasoundObstetrics = ChronologyPregnancy.UltrasoundObstetrics;
            model.FPP = ChronologyPregnancy.FPP;
            model.FPC = ChronologyPregnancy.FPC;
            


            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(ChronologyPregnancyActionViewModel model)
        {
            if (model.ID != 0)
            {
                var ChronologyPregnancy = ChronologyPregnancyServices.Instance.GetChronologyPregnancy(model.ID);

                ChronologyPregnancy.ID = model.ID;
                ChronologyPregnancy.ReliableFUM = model.ReliableFUM;
                ChronologyPregnancy.UltrasoundObstetrics = model.UltrasoundObstetrics;
                ChronologyPregnancy.FPP = model.FPP;
                ChronologyPregnancy.FPC = model.FPC;
                

                ChronologyPregnancyServices.Instance.UpdateChronologyPregnancys(ChronologyPregnancy);


            }
            else
            {
                var ChronologyPregnancy = new ChronologyPregnancy();
                ChronologyPregnancy.ReliableFUM = model.ReliableFUM;
                ChronologyPregnancy.UltrasoundObstetrics = model.UltrasoundObstetrics;
                ChronologyPregnancy.FPP = model.FPP;
                ChronologyPregnancy.FPC = model.FPC;
               

                ChronologyPregnancyServices.Instance.SaveChronologyPregnancys(ChronologyPregnancy);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ChronologyPregnancyActionViewModel model = new ChronologyPregnancyActionViewModel();

            var ChronologyPregnancy = ChronologyPregnancyServices.Instance.GetChronologyPregnancy(ID);
            model.ID = ChronologyPregnancy.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(ChronologyPregnancyActionViewModel model)
        {

            ChronologyPregnancyServices.Instance.DeleteChronologyPregnancys(model.ID);









            return Json(new { success = true });
        }
    }
}

