﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;

namespace MEASS.ConsoleUI.AdminModule
{
    public class AdminClass
    {
        private readonly IAdminService _adminService = InstanceFactory.GetInstance<IAdminService>();
        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();

        
        public void AdminLoginRegisterMenu()
        {
            Console.WriteLine("\t\t\tWelcome Admin Login - Register Panel");
            Console.WriteLine("1- Login");
            Console.WriteLine("2- Back To Main Menu");
            Console.WriteLine("0- Exit");

            Console.Write("please choose (0-2): ");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    AdminLogin();
                    break;
                case 2:
                    Console.Clear();
                    Program.MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        private void AdminMenu()
        {
            Console.WriteLine("\t\t\tWelcome Admin Panel");
            Console.WriteLine("1- Add User");
            Console.WriteLine("2- Update User");
            Console.WriteLine("3- Delete User");
            Console.WriteLine("4- Get User");
            Console.WriteLine("5- GetAll User");
            Console.WriteLine("6- Back To Main Menu");
            Console.WriteLine("0- Exit");

            Console.Write("please choose (0-5): ");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    AddUserUi();
                    break;
                case 2:
                    Console.Clear();
                    UpdateUserUi();
                    break;
                case 3:
                    Console.Clear();
                    DeleteUserUi();
                    break;
                case 4:
                    Console.Clear();
                    GetUserByUserNameUi();
                    break;
                case 5:
                    Console.Clear();
                    GetAllUsersUi();
                    break;
                case 6:
                    Console.Clear();
                    Program.MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        private void MiddleMenu()
        {
            Console.WriteLine("\n\n1- Back");
            Console.WriteLine("0- Exit");
            Console.Write("please choose (0-1): ");
            var choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    AdminMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void AdminLogin()
        {
            Console.WriteLine("\t\t\tAdmin Login");
            Console.Write("Username : ");
            var userName = Console.ReadLine();
            Console.Write("Password : ");
            var password = Console.ReadLine();
            var admin = _adminService.GetAdminByAdminNameAndPassword(userName, password);
            if (admin != null)
            {
                Console.WriteLine("Logging in please wait...");
                Console.Clear();
                AdminMenu();
            }
            else
            {
                Console.WriteLine("username or password is incorrect");
            }
        }

        private void AddUserUi()
        {
            Console.WriteLine("\t\t\tAdd User");
            Console.Write("First Name : ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            var lastName = Console.ReadLine();
            Console.Write("Email : ");
            var email = Console.ReadLine();
            Console.Write("Gender (Male/Female) : ");
            var gender = Console.ReadLine();
            Console.Write("Username : ");
            var userName = Console.ReadLine();
            Console.Write("Password : ");
            var userPassword = Console.ReadLine();
            Console.Clear();
            var user = GetUserByUserName(userName);
            if (user == null)
            {
                var addedUser = AddUser(new User
                {
                    UserFirstName = firstName,
                    UserLastName = lastName,
                    UserGender = gender,
                    UserEmail = email,
                    UserName = userName,
                    UserPassword = userPassword
                });
                if (addedUser != null)
                {
                    Console.WriteLine("User added!");
                }
                else
                {
                    Console.WriteLine("Could not add user!");
                }

            }
            else
            {
                Console.WriteLine("User already exists!");
            }

            MiddleMenu();
        }
        private void UpdateUserUi()
        {
            Console.WriteLine("\t\t\tGet User");
            Console.Write("User Name : ");
            var name = Console.ReadLine();
            Console.Clear();

            if (name != null)
            {
                Console.WriteLine("\t\t\tUpdate User");
                var user = GetUserByUserName(name);
                if (user != null)
                {
                    Console.WriteLine($"First Name : {user.UserFirstName}");
                    Console.WriteLine($"Last Name : {user.UserLastName}");
                    Console.WriteLine($"Email : {user.UserEmail}");
                    Console.WriteLine($"Gender : {user.UserGender}");
                    Console.WriteLine($"Username : {user.UserName}");
                    Console.WriteLine($"Password : {user.UserPassword}");

                    Console.Write("\n\nFirst Name To Update : ");
                    var firstName = Console.ReadLine();
                    Console.Write("Last Name To Update : ");
                    var lastName = Console.ReadLine();
                    Console.Write("Email To Update : ");
                    var email = Console.ReadLine();
                    Console.Write("Gender To Update (Male/Female) : ");
                    var gender = Console.ReadLine();
                    Console.Write("Username To Update : ");
                    var userName = Console.ReadLine();
                    Console.Write("Password To Update : ");
                    var userPassword = Console.ReadLine();
                    Console.Clear();
                    UpdateUser(new User
                    {
                        Id = user.Id,
                        UserFirstName = firstName,
                        UserLastName = lastName,
                        UserGender = gender,
                        UserEmail = email,
                        UserName = userName,
                        UserPassword = userPassword
                    });
                    Console.WriteLine("User updated!");
                }
                else
                {
                    Console.WriteLine("User not found!");
                }
            }

            MiddleMenu();
        }
        private void DeleteUserUi()
        {
            Console.WriteLine("\t\t\tGet User");
            Console.Write("User Name : ");
            var name = Console.ReadLine();
            Console.Clear();

            if (name != null)
            {
                Console.WriteLine("\t\t\tDelete User");
                var user = GetUserByUserName(name);
                if (user != null)
                {
                    DeleteUser(user);
                    Console.WriteLine("User deleted!");
                }
                else
                {
                    Console.WriteLine("User not found!");
                }
            }

            MiddleMenu();

        }
        private User GetUserByUserNameUi()
        {
            Console.WriteLine("\t\t\tGet User");
            Console.Write("User Name : ");
            var userName = Console.ReadLine();
            Console.Clear();

            if (userName != null)
            {
                var user = GetUserByUserName(userName);
                if (user != null)
                {
                    Console.WriteLine($"First Name : {user.UserFirstName}");
                    Console.WriteLine($"Last Name : {user.UserLastName}");
                    Console.WriteLine($"Email : {user.UserEmail}");
                    Console.WriteLine($"Gender : {user.UserGender}");
                    Console.WriteLine($"Username : {user.UserName}");
                    Console.WriteLine($"Password : {user.UserPassword}"); 
                    MiddleMenu();
                    return user;
                }

                Console.WriteLine("User not found!");
            }

            MiddleMenu();
            return null;
        }
        private void GetAllUsersUi()
        {
            List<User> users = GetAllUsers();
            Console.WriteLine("\t\t\tAll Users");

            foreach (var user in users)
            {
                Console.WriteLine($"First Name : {user.UserFirstName}");
                Console.WriteLine($"Last Name : {user.UserLastName}");
                Console.WriteLine($"Email : {user.UserEmail}");
                Console.WriteLine($"Gender : {user.UserGender}");
                Console.WriteLine($"Username : {user.UserName}");
                Console.WriteLine($"Password : {user.UserPassword}");
                Console.WriteLine("\n\n");
            }

            MiddleMenu();

        }

        private User AddUser(User user)
        {
            return _userService.AddUser(user);
        }
        private void UpdateUser(User user)
        {
            _userService.UpdateUser(user);
        }
        private void DeleteUser(User user)
        {
            _userService.DeleteUser(user);
        }
        private List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }
        private User GetUserByUserName(string userName)
        {
            return _userService.GetUserByUserName(userName);
        }
    }
}
