﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        List<User> GetUsersByUserName(string userName);
        User GetUserByUserName(string userName);
        User GetUserByUserNameAndPassword(string userName, string password);
        User AddUser(User user);
        User UpdateUser(User user);
        void DeleteUser(User user);
    }
}
