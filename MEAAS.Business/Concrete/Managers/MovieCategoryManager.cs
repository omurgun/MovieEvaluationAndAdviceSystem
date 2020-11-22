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
    public class MovieCategoryManager:IMovieCategoryService
    {
        private readonly IMovieCategoryDal _movieCategoryDal;

        public MovieCategoryManager(IMovieCategoryDal movieCategoryDal)
        {
            _movieCategoryDal = movieCategoryDal;
        }

        public List<MovieCategory> GetAllMovieCategories()
        {
            return _movieCategoryDal.GetAll();
        }

        public List<MovieCategory> GetMovieCategoriesByCategoryName(string movieCategoryName)
        {
            return _movieCategoryDal.GetAll(mc => mc.MovieCategoryName.ToLower().Contains(movieCategoryName.ToLower()));
        }

        public MovieCategory GetMovieCategoryByMovieCategoryName(string movieCategoryName)
        {
            return _movieCategoryDal.Get(mc => mc.MovieCategoryName.Equals(movieCategoryName));
        }

        public MovieCategory AddMovieCategory(MovieCategory movieCategory)
        {
            return _movieCategoryDal.Add(movieCategory);
        }

        public MovieCategory UpdateMovieCategory(MovieCategory movieCategory)
        {
            return _movieCategoryDal.Update(movieCategory);
        }

        public void DeleteMovieCategory(MovieCategory movieCategory)
        {
            _movieCategoryDal.Delete(movieCategory);
        }
    }
}
