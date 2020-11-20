using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEASS.ConsoleUI.AdminModule;
using MEASS.ConsoleUI.UserModule;

namespace MEASS.ConsoleUI
{
    class Program
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
            }
        }

        public static void MainMenu()
        {
            Console.WriteLine("\t\t\tWelcome Main Menu");
            Console.WriteLine("1- Admin Panel");
            Console.WriteLine("2- User Panel");
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
                    AdminClass adminPanel = new AdminClass();
                    adminPanel.AdminLoginRegisterMenu();
                    break;
                case 2:
                    Console.Clear();
                    UserClass userPanel = new UserClass();
                    userPanel.UserMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        }
    }
}
