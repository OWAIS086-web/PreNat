using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreNat.Controllers
{
    public class ImmunizationsController : Controller
    {
        // GET: Immunizations
        public ActionResult Index()
        {
            return View();
        }
    }
}