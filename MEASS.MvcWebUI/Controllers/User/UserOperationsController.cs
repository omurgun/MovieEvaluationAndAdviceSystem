using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;

namespace MEASS.MvcWebUI.Controllers.User
{
    public class UserOperationsController : Controller
    {
        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();

        // GET: UserOperations
        public ActionResult Index()
        {
            return View();
        }
    }
}