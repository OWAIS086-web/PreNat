using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using PreNat.Services;
using PreNat.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PreNat.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient



        //public ActionResult Index(string SearchTerm = "")
        //{
        //    CompanyListingViewModel model = new CompanyListingViewModel();
        //    model.Companies = CompanyServices.Instance.GetCompanies(SearchTerm);
        //    return View("Index", "_Layout", model);
        //}





        //[HttpGet]
        //public ActionResult Action(int ID = 0)
        //{
        //    CompanyActionViewModel model = new CompanyActionViewModel();
        //    model.LegalStatuses = CompanyServices.Instance.GetLegalStatuses();
        //    if (ID != 0)
        //    {
        //        var Company = CompanyServices.Instance.GetCompany(ID);
        //        model.ID = Company.ID;
        //        model.Name = Company.Name;
        //        model.LegalStatus = Company.LegalStatus;
        //        model.NoOfCommercialRegister = Company.NoOfCommercialRegister;
        //        model.NoOfTaxID = Company.NoOfTaxID;
        //        model.Activity = Company.Activity;
        //        model.Address = Company.Address;
        //        model.CreationDate = Company.CreationDate;
        //        model.Doc = Company.Doc;
        //        model.CompanyIcon = Company.CompanyIcon;
        //        model.SocialCapital = Company.SocialCapital;

        //    }
        //    return PartialView("_Action", model);
        //}


        //[HttpGet]
        //public ActionResult View(int ID)
        //{
        //    CompanyActionViewModel model = new CompanyActionViewModel();
        //    var Company = CompanyServices.Instance.GetCompany(ID);
        //    model.LegalStatuses = CompanyServices.Instance.GetLegalStatuses();
        //    model.ID = Company.ID;
        //    model.Name = Company.Name;
        //    model.LegalStatus = Company.LegalStatus;
        //    model.NoOfCommercialRegister = Company.NoOfCommercialRegister;
        //    model.NoOfTaxID = Company.NoOfTaxID;
        //    model.Activity = Company.Activity;
        //    model.Address = Company.Address;
        //    model.CreationDate = Company.CreationDate;
        //    model.SocialCapital = Company.SocialCapital;
        //    model.Doc = Company.Doc;
        //    model.CompanyIcon = Company.CompanyIcon;


        //    return View("View", "_Layout", model);
        //}


        //[HttpPost]
        ///public ActionResult Action(CompanyActionViewModel model)
        //{
        //    if (model.ID != 0)
        //    {
        //        var Company = CompanyServices.Instance.GetCompany(model.ID);

        //        Company.ID = model.ID;
        //        Company.Name = model.Name;
        //        Company.LegalStatus = model.LegalStatus;
        //        Company.NoOfCommercialRegister = model.NoOfCommercialRegister;
        //        Company.NoOfTaxID = model.NoOfTaxID;
        //        Company.Activity = model.Activity;
        //        Company.Address = model.Address;
        //        Company.CreationDate = model.CreationDate;
        //        Company.Doc = model.Doc;
        //        Company.SocialCapital = model.SocialCapital;
        //        Company.CompanyIcon = model.CompanyIcon;

        //        CompanyServices.Instance.UpdateCompanies(Company);

        //        var log = new Log();
        //        log.Email = UserManager.FindById(User.Identity.GetUserId()).Email;
        //        log.LogDate = DateTime.Now;
        //        log.Task = "Company Updated by " + UserManager.FindById(User.Identity.GetUserId()).Name;
        //        LogServices.Instance.Savelogs(log);
        //    }
        //    else
        //    {
        //        var company = new Company();

        //        company.Name = model.Name;
        //        company.LegalStatus = model.LegalStatus;
        //        company.NoOfCommercialRegister = model.NoOfCommercialRegister;
        //        company.NoOfTaxID = model.NoOfTaxID;
        //        company.Activity = model.Activity;
        //        company.Address = model.Address;
        //        company.CreationDate = DateTime.Now;
        //        company.Doc = model.Doc;
        //        company.SocialCapital = model.SocialCapital;
        //        company.CompanyIcon = model.CompanyIcon;
        //        CompanyServices.Instance.SaveCompanies(company);

        //        var log = new Log();
        //        log.Email = UserManager.FindById(User.Identity.GetUserId()).Email;
        //        log.LogDate = DateTime.Now;
        //        log.Task = "Company Saved by " + UserManager.FindById(User.Identity.GetUserId()).Name;
        //        LogServices.Instance.Savelogs(log);
        //    }
        //    return Json(new { success = true });
        //}


        //[HttpGet]
        //public ActionResult Delete(int ID)
        //{
        //    CompanyActionViewModel model = new CompanyActionViewModel();

        //    var Company = CompanyServices.Instance.GetCompany(ID);
        //    model.ID = Company.ID;

        //    return PartialView("_Delete", model);
        //}


        //[HttpPost]
        //public ActionResult Delete(CompanyActionViewModel model)
        //{

        //    CompanyServices.Instance.DeleteCompanies(model.ID);









        //    return Json(new { success = true });
        //}
    }
}

