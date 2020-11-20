using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAllAdmins();
        Admin GetAdminByAdminName(string adminName);
        Admin GetAdminByAdminNameAndPassword(string adminName, string password);
        Admin AddAdmin(Admin admin);
        Admin UpdateAdmin(Admin admin);
        void DeleteAdmin(Admin admin);
    }
}
