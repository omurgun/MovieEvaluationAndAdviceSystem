using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Business.Abstract;
using MEAAS.DataAccess.Abstract;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User AddUser(User user)
        {
            return _userDal.Add(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAllUsers()
        {
            return _userDal.GetAll();
        }

        public User UpdateUser(User user)
        {
            return _userDal.Update(user);
        }

        public User GetUserByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName.Equals(userName));
        }

        public User GetUserByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName.Equals(userName) && u.UserPassword.Equals(password));
        }

    }
}
