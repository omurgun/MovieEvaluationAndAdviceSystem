using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;

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

        public string Login()
        {
            var adminName = "verytr";
            var password = "1234";

            if (adminName == string.Empty || password == string.Empty)
            {
                return "can't be blank";
            }
            else
            {
                var admin = _adminService.GetAdminByAdminNameAndPassword(adminName, password);
                if (admin != null)
                {

                    return "Login successful..";
                }
                else
                {
                    return "Admin name or password is incorrect!";
                }
            }
        }

    }
}