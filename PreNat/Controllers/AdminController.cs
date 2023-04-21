﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PreNat.Services;
using PreNat.ViewModels;
using PreNat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreNat.Controllers
{
    public class AdminController : Controller
    {
        private AMSignInManager _signInManager;
        private AMRolesManager _rolesManager;
        private AMUserManager _userManager;
        public AMUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AMUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public AMRolesManager RolesManager
        {
            get
            {
                return _rolesManager ?? HttpContext.GetOwinContext().GetUserManager<AMRolesManager>();
            }
            private set
            {
                _rolesManager = value;
            }
        }
        public AMSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<AMSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }
        // GET: Admin
        public ActionResult Index()
        {
            AdminViewModel model = new AdminViewModel();
            var user = UserManager.FindById(User.Identity.GetUserId());
            model.Name = user.Name;
            return View(model);
        }


        [HttpPost]
        public JsonResult GetPaitents(string Prefix)
        {
            var patients = PatientServices.Instance.GetPatients(Prefix).Distinct().ToList();
            return Json(patients, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Dashboard()
        {
            MainActionViewModel model = new MainActionViewModel();
            var user = UserManager.FindById(User.Identity.GetUserId());
            model.Patients = PatientServices.Instance.GetPatients();
            model.SignedInUser = user;
            return View(model);
        }



        [HttpPost]
        public ActionResult Dashboard(string SearchTerm)
        {
            AdminViewModel model = new AdminViewModel();
            var user = UserManager.FindById(User.Identity.GetUserId());
            model.SignedInUser = user;
            return View(model);
        }


    }
}