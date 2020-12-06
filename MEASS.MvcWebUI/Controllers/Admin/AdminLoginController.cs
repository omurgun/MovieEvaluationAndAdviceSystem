using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEASS.MvcWebUI.Models;

namespace MEASS.MvcWebUI.Controllers.Admin
{
    public class AdminLoginController : Controller
    {
        private readonly IAdminService _adminService = InstanceFactory.GetInstance<IAdminService>();

        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Models.Admin admin)
        {
            
            var adminName = admin.AdminName;
            var password = admin.AdminPassword;

            if (adminName == string.Empty || password == string.Empty)
            {
                return RedirectToAction("Error", "Default");
            }
            else
            {
                var _admin = _adminService.GetAdminByAdminNameAndPassword(adminName, password);
                if (_admin != null)
                {

                    return RedirectToAction("Index", "AdminHome");
                }
                else
                {
                    return RedirectToAction("Error", "Default");
                }
            }
        }

    }
}