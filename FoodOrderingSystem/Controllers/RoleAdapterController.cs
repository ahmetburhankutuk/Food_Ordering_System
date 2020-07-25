using FoodOrderingSystem.App_Classes;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FoodOrderingSystem.Controllers
{
    public class RoleAdapterController : Controller
    {
        // GET: RoleAdapter
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AttendRole(string KullaniciAdi, string RolAdi)
        {
            Roles.AddUserToRole(KullaniciAdi, RolAdi);
            return RedirectToAction("Index");
        }

    }
}