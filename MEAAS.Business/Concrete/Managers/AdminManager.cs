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
    public class AdminManager:IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }


        public List<Admin> GetAllAdmins()
        {
            return _adminDal.GetAll();
        }

        public Admin GetAdminByAdminName(string adminName)
        {
            return _adminDal.Get(a => a.AdminName.Equals(adminName));
        }

        public Admin GetAdminByAdminNameAndPassword(string adminName, string password)
        {
            return _adminDal.Get(a => a.AdminName.Equals(adminName) && a.AdminPassword.Equals(password));
        }

        public Admin AddAdmin(Admin admin)
        {
            return _adminDal.Add(admin);
        }

        public Admin UpdateAdmin(Admin admin)
        {
            return _adminDal.Update(admin);
        }

        public void DeleteAdmin(Admin admin)
        {
            _adminDal.Delete(admin);
        }
    }
}
