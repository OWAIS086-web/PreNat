using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class BackgroundController : Controller
    {
        // GET: Background



        public ActionResult Index(string SearchTerm = "")
        {
            BackgroundListingViewModel model = new BackgroundListingViewModel();
            model.Backgrounds = BackgroundServices.Instance.GetBackgrounds(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            BackgroundActionViewModel model = new BackgroundActionViewModel();
            if (ID != 0)
            {


                var Background = BackgroundServices.Instance.GetBackground(ID);
                model.ID = Background.ID;
                model.Tbc = Background.Tbc;
                model.Diabetes = Background.Diabetes;
                model.Hypertension = Background.Hypertension;
                model.Eclampsia = Background.Eclampsia;
                model.Preeclampsia = Background.Preeclampsia;
                model.Surgery = Background.Surgery;
                model.Infertility = Background.Infertility;
                model.Cardiopathy = Background.Cardiopathy;
                model.Nephropathy = Background.Nephropathy;
                model.Violence = Background.Violence;
                model.VIH = Background.VIH;
                model.Migraine = Background.Migraine;
                model.Enf_Tromboembólica = Background.Enf_Tromboembólica;
                model.IMC29 = Background.IMC29;
                model.IMC39 = Background.IMC39;
                model.Disc_Sang = Background.Disc_Sang;
                model.other_dises = Background.other_dises;

            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            BackgroundActionViewModel model = new BackgroundActionViewModel();
            var Background = BackgroundServices.Instance.GetBackground(ID);
            model.Tbc = Background.Tbc;
            model.Diabetes = Background.Diabetes;
            model.Hypertension = Background.Hypertension;
            model.Eclampsia = Background.Eclampsia;
            model.Preeclampsia = Background.Preeclampsia;
            model.Surgery = Background.Surgery;
            model.Infertility = Background.Infertility;
            model.Cardiopathy = Background.Cardiopathy;
            model.Nephropathy = Background.Nephropathy;
            model.Violence = Background.Violence;
            model.VIH = Background.VIH;
            model.Migraine = Background.Migraine;
            model.Enf_Tromboembólica = Background.Enf_Tromboembólica;
            model.IMC29 = Background.IMC29;
            model.IMC39 = Background.IMC39;
            model.Disc_Sang = Background.Disc_Sang;
            model.other_dises = Background.other_dises;

            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(BackgroundActionViewModel model)
        {
            if (model.ID != 0)
            {
                var Background = BackgroundServices.Instance.GetBackground(model.ID);

                Background.ID = model.ID;
                Background.Tbc = model.Tbc;
                Background.Diabetes = model.Diabetes;
                Background.Hypertension = model.Hypertension;
                Background.Eclampsia = model.Eclampsia;
                Background.Preeclampsia = model.Preeclampsia;
                Background.Surgery = model.Surgery;
                Background.Infertility = model.Infertility;
                Background.Cardiopathy = model.Cardiopathy;
                Background.Nephropathy = model.Nephropathy;
                Background.Violence = model.Violence;
                Background.VIH = model.VIH;
                Background.Migraine = model.Migraine;
                Background.Enf_Tromboembólica = model.Enf_Tromboembólica;
                Background.IMC29 = model.IMC29;
                Background.IMC39 = model.IMC39;
                Background.Disc_Sang = model.Disc_Sang;
                Background.other_dises = model.other_dises;

                BackgroundServices.Instance.UpdateBackgrounds(Background);


            }
            else
            {
                var Background = new Background();
                Background.Tbc = model.Tbc;
                Background.Diabetes = model.Diabetes;
                Background.Hypertension = model.Hypertension;
                Background.Eclampsia = model.Eclampsia;
                Background.Preeclampsia = model.Preeclampsia;
                Background.Surgery = model.Surgery;
                Background.Infertility = model.Infertility;
                Background.Cardiopathy = model.Cardiopathy;
                Background.Nephropathy = model.Nephropathy;
                Background.Violence = model.Violence;
                Background.VIH = model.VIH;
                Background.Migraine = model.Migraine;
                Background.Enf_Tromboembólica = model.Enf_Tromboembólica;
                Background.IMC29 = model.IMC29;
                Background.IMC39 = model.IMC39;
                Background.Disc_Sang = model.Disc_Sang;
                Background.other_dises = model.other_dises;

                BackgroundServices.Instance.SaveBackgrounds(Background);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            BackgroundActionViewModel model = new BackgroundActionViewModel();

            var Background = BackgroundServices.Instance.GetBackground(ID);
            model.ID = Background.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(BackgroundActionViewModel model)
        {

            BackgroundServices.Instance.DeleteBackgrounds(model.ID);









            return Json(new { success = true });
        }
    }
}

