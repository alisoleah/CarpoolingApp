using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

using BackendDellEmc.Models;
using BackendDellEmc.ViewModel;

namespace BackendDellEmc.Controllers
{
    public class xUserController : Controller
    {
        // GET: User  
        public ActionResult Index()
        {
            UserClient CC = new UserClient();
            ViewBag.listCustomers = CC.findAll();

            return View();
        }
        [System.Web.Http.HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [System.Web.Http.HttpPost]
        public System.Web.Mvc.ActionResult Create(UserViewModel cvm)
        {
            UserClient CC = new UserClient();
            CC.Create(cvm.user);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            UserClient CC = new UserClient();
            CC.Delete(id);
            return RedirectToAction("Index");
        }
        [System.Web.Http.HttpGet]
        public ActionResult Edit(int id)
        {
            UserClient CC = new UserClient();
            UserViewModel CVM = new UserViewModel();
            CVM.user = CC.find(id);
            return View("Edit", CVM);
        }
        [System.Web.Http.HttpPost]
        public ActionResult Edit(UserViewModel CVM)
        {
            UserClient CC = new UserClient();
            CC.Edit(CVM.user);
            return RedirectToAction("Index");
        }
    }
}
