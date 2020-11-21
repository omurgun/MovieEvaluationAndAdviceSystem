using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Business.Abstract;
using MEAAS.Business.Concrete.Managers;
using MEAAS.DataAccess.Abstract;
using MEAAS.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MEAAS.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<IAdminService>().To<AdminManager>();
            Bind<IAdminDal>().To<EfAdminDal>();

            Bind<IMovieService>().To<MovieManager>();
            Bind<IMovieDal>().To<EfMovieDal>();

            Bind<IMovieCategoryService>().To<MovieCategoryManager>();
            Bind<IMovieCategoryDal>().To<EfMovieCategoryDal>();
        }
    }
}
