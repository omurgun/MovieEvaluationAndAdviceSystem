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

        public string Login()
        {
            try
            {
                var userName = "verytr";
                var password = "1234";

                if (userName == string.Empty || password == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var user = _userService.GetUserByUserNameAndPassword(userName, password);
                    if (user != null)
                    {
                        return "Login successful..";
                    }
                    else
                    {
                        return "User name or password is incorrect!";
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string Register()
        {
            try
            {
                var firstName = "reis";
                var lastName = "reis";
                var email = "reis";
                var gender = "Male";
                var userName = "reis";
                var password = "0000";


                if (firstName == string.Empty || lastName == string.Empty || email == string.Empty || userName == string.Empty || password == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var user = _userService.GetUserByUserName(userName);
                    if (user == null)
                    {
                        var savedUser = _userService.AddUser(new MEAAS.Entities.Concrete.User
                        {
                            UserFirstName = firstName,
                            UserLastName = lastName,
                            UserGender = gender,
                            UserEmail = email,
                            UserName = userName,
                            UserPassword = password
                        });
                        if (savedUser != null)
                        {
                            return "Registration Successful..";
                        }
                        else
                        {
                            return "Couldn't add new user!!";
                        }
                    }
                    else
                    {
                        return "this user has already been added";
                    }
                }

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

    }
}