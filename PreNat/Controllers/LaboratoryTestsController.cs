using PreNat.Services;
using PreNat.ViewModels;
using System.Web.Mvc;
using PreNat.Entities;

namespace PreNat.Controllers
{
    public class LaboratoryTestsController : Controller
    {
        // GET: LaboratoryTests



        public ActionResult Index(string SearchTerm = "")
        {
            LaboratoryTestsListingViewModel model = new LaboratoryTestsListingViewModel();
            model.LaboratoryTestss = LaboratoryTestsServices.Instance.GetLaboratoryTestss(SearchTerm);
            return View("Index", "_Layout", model);
        }





        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult Action(int ID = 0)
        {
            LaboratoryTestsActionViewModel model = new LaboratoryTestsActionViewModel();
            if (ID != 0)
            {


                var LaboratoryTests = LaboratoryTestsServices.Instance.GetLaboratoryTests(ID);
                model.ID = LaboratoryTests.ID;
                model.GroupPositve = LaboratoryTests.GroupPositve;
                model.SanguineoGroup = LaboratoryTests.SanguineoGroup;
                model.GroupNegative = LaboratoryTests.GroupNegative;
                model.VDRL = LaboratoryTests.VDRL;
                model.Syphilis = LaboratoryTests.Syphilis;
                model.VIH_L = LaboratoryTests.VIH_L;


            }
            return View(model);
        }


        // In Active HTTPGET model.JoElement  = variable.JoElement;
        [HttpGet]
        public ActionResult View(int ID)
        {
            LaboratoryTestsActionViewModel model = new LaboratoryTestsActionViewModel();
            var LaboratoryTests = LaboratoryTestsServices.Instance.GetLaboratoryTests(ID);
            model.GroupPositve = LaboratoryTests.GroupPositve;
            model.SanguineoGroup = LaboratoryTests.SanguineoGroup;
            model.GroupNegative = LaboratoryTests.GroupNegative;
            model.VDRL = LaboratoryTests.VDRL;
            model.Syphilis = LaboratoryTests.Syphilis;
            model.VIH_L = LaboratoryTests.VIH_L;



            return View("View", "_Layout", model);
        }


        [HttpPost]
        // In Active HTTPOST varable.JoElement  = nodel.JoElement;....................

        public ActionResult Action(LaboratoryTestsActionViewModel model)
        {
            if (model.ID != 0)
            {
                var LaboratoryTests = LaboratoryTestsServices.Instance.GetLaboratoryTests(model.ID);

                LaboratoryTests.ID = model.ID;
                LaboratoryTests.GroupNegative = model.GroupNegative;
                LaboratoryTests.SanguineoGroup = model.SanguineoGroup;
                LaboratoryTests.GroupPositve = model.GroupPositve;
                LaboratoryTests.VDRL = model.VDRL;
                LaboratoryTests.Syphilis = model.Syphilis;
                LaboratoryTests.VIH_L = model.VIH_L;


                LaboratoryTestsServices.Instance.UpdateLaboratoryTestss(LaboratoryTests);


            }
            else
            {
                var LaboratoryTests = new LaboratoryTests();
                LaboratoryTests.GroupNegative = model.GroupNegative;
                LaboratoryTests.SanguineoGroup = model.SanguineoGroup;
                LaboratoryTests.GroupPositve = model.GroupPositve;
                LaboratoryTests.VDRL = model.VDRL;
                LaboratoryTests.Syphilis = model.Syphilis;
                LaboratoryTests.VIH_L = model.VIH_L;

                LaboratoryTestsServices.Instance.SaveLaboratoryTestss(LaboratoryTests);


            }
            return Json(new { success = true });
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            LaboratoryTestsActionViewModel model = new LaboratoryTestsActionViewModel();

            var LaboratoryTests = LaboratoryTestsServices.Instance.GetLaboratoryTests(ID);
            model.ID = LaboratoryTests.ID;

            return PartialView("_Delete", model);
        }


        [HttpPost]
        public ActionResult Delete(LaboratoryTestsActionViewModel model)
        {

            LaboratoryTestsServices.Instance.DeleteLaboratoryTestss(model.ID);









            return Json(new { success = true });
        }
    }
}

