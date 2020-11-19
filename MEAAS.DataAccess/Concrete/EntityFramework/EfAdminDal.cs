using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Core.DataAccess.EntityFramework;
using MEAAS.DataAccess.Abstract;
using MEAAS.Entities.Concrete;

namespace MEAAS.DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal:EfEntityRepositoryBase<Admin,MovieContext>,IAdminDal
    {

    }
}
