using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class ObstetrichistoryController : Controller
    {
        // GET: Obstetrichistory



        public ActionResult Index(string SearchTerm = "")
        {
            ObstetrichistoryListingViewModel model = new ObstetrichistoryListingViewModel();
            model.Obstetrichistory = ObstetrichistoryServices.Instance.GetObstetrichistorys(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            ObstetrichistoryActionViewModel model = new ObstetrichistoryActionViewModel();
            if (ID != 0)
            {


                var Obstetrichistory = ObstetrichistoryServices.Instance.GetObstetrichistory(ID);
                model.ID = Obstetrichistory.ID;
                model.Gestationes_Pregnancies = Obstetrichistory.Gestationes_Pregnancies;
                model.Delivery = Obstetrichistory.Delivery;
                model.Term = Obstetrichistory.Term;
                model.Premature = Obstetrichistory.Premature;
                model.Vaginal = Obstetrichistory.Vaginal;
                model.Cesareas = Obstetrichistory.Cesareas;
                model.Abortions = Obstetrichistory.Abortions;
                model.Gemerales = Obstetrichistory.Gemerales;
                model.Ectopicos = Obstetrichistory.Ectopicos;
                model.Obitos = Obstetrichistory.Obitos;
                model.Springs = Obstetrichistory.Springs;
                model.Live_Births = Obstetrichistory.Live_Births;
              

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            ObstetrichistoryActionViewModel model = new ObstetrichistoryActionViewModel();
            var Obstetrichistory = ObstetrichistoryServices.Instance.GetObstetrichistory(ID);
            model.Gestationes_Pregnancies = Obstetrichistory.Gestationes_Pregnancies;
            model.Delivery = Obstetrichistory.Delivery;
            model.Term = Obstetrichistory.Term;
            model.Premature = Obstetrichistory.Premature;
            model.Vaginal = Obstetrichistory.Vaginal;
            model.Cesareas = Obstetrichistory.Cesareas;
            model.Abortions = Obstetrichistory.Abortions;
            model.Gemerales = Obstetrichistory.Gemerales;
            model.Ectopicos = Obstetrichistory.Ectopicos;
            model.Obitos = Obstetrichistory.Obitos;
            model.Springs = Obstetrichistory.Springs;
            model.Live_Births = Obstetrichistory.Live_Births;



            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(ObstetrichistoryActionViewModel model)
        {
            if (model.ID != 0)
            {
                var Obstetrichistory = ObstetrichistoryServices.Instance.GetObstetrichistory(model.ID);

                Obstetrichistory.ID = model.ID;
                Obstetrichistory.Gestationes_Pregnancies = model.Gestationes_Pregnancies;
                Obstetrichistory.Delivery = model.Delivery;
                Obstetrichistory.Term = model.Term;
                Obstetrichistory.Premature = model.Premature;
                Obstetrichistory.Vaginal = model.Vaginal;
                Obstetrichistory.Cesareas = model.Cesareas;
                Obstetrichistory.Abortions = model.Abortions;
                Obstetrichistory.Gemerales = model.Gemerales;
                Obstetrichistory.Ectopicos = model.Ectopicos;
                Obstetrichistory.Obitos = model.Obitos;
                Obstetrichistory.Springs = model.Springs;
                Obstetrichistory.Live_Births = model.Live_Births;

                ObstetrichistoryServices.Instance.UpdateObstetrichistorys(Obstetrichistory);


            }
            else
            {
                var Obstetrichistory = new Obstetrichistory();
                Obstetrichistory.Gestationes_Pregnancies = model.Gestationes_Pregnancies;
                Obstetrichistory.Delivery = model.Delivery;
                Obstetrichistory.Term = model.Term;
                Obstetrichistory.Premature = model.Premature;
                Obstetrichistory.Vaginal = model.Vaginal;
                Obstetrichistory.Cesareas = model.Cesareas;
                Obstetrichistory.Abortions = model.Abortions;
                Obstetrichistory.Gemerales = model.Gemerales;
                Obstetrichistory.Ectopicos = model.Ectopicos;
                Obstetrichistory.Obitos = model.Obitos;
                Obstetrichistory.Springs = model.Springs;
                Obstetrichistory.Live_Births = model.Live_Births;


                ObstetrichistoryServices.Instance.SaveObstetrichistorys(Obstetrichistory);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ObstetrichistoryActionViewModel model = new ObstetrichistoryActionViewModel();

            var Obstetrichistory = ObstetrichistoryServices.Instance.GetObstetrichistory(ID);
            model.ID = Obstetrichistory.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(ObstetrichistoryActionViewModel model)
        {

            ObstetrichistoryServices.Instance.DeleteObstetrichistorys(model.ID);









            return Json(new { success = true });
        }
    }
}

