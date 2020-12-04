using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;


namespace MEASS.MvcWebUI.Controllers
{
    public class AdminUserOperationsController : Controller
    {

        private readonly IAdminService _adminService = InstanceFactory.GetInstance<IAdminService>();
        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();


        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public string AddUser()
        {
            try
            {
                var firstName = "firstname";
                var lastName = "lastname";
                var email = "email";
                var gender = "Male";
                var userName = "username";
                var password = "1234";


                if (firstName == string.Empty || lastName == string.Empty || email == string.Empty || userName == string.Empty || password == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var user = _userService.GetUserByUserName(userName);
                    if (user == null)
                    {
                        var savedUser = _userService.AddUser(new User
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
                            return "new user added.";

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
        public string UpdateUser()
        {
            try
            {
                var updateFirstName = "firstname";
                var updateLastName = "lastname";
                var updateEmail = "email";
                var updateGender = "Male";
                var updateUserName = "username";
                var updatePassword = "1234";


                if (updateFirstName == string.Empty || updateLastName == string.Empty || updateEmail == string.Empty || updateGender == string.Empty ||
                    updateUserName == string.Empty || updatePassword == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var user = _userService.GetUserByUserName(updateUserName);
                    if (user != null)
                    {
                        var updatedUser = _userService.UpdateUser(new User
                        {
                            Id = user.Id,
                            UserFirstName = updateFirstName,
                            UserLastName = updateLastName,
                            UserEmail = updateEmail,
                            UserGender = updateGender,
                            UserName = updateUserName,
                            UserPassword = updatePassword
                        });
                        if (updatedUser != null)
                        {
                            
                            return "user updated.";
                        }
                        else
                        {
                            return "Couldn't update user!!";
                        }

                    }
                    else
                    {
                        return "There is no such user";
                    }
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string DeleteUser()
        {
            try
            {
                _userService.DeleteUser(new User
                {
                    Id = 1
                });
                return "User Deleted!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
           
            
        }
        public string SearchByUserName()
        {
            var users = _userService.GetAllUsers();
            return users.Count.ToString();
        }
    }
}