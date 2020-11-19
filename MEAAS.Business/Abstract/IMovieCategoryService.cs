using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Abstract
{
    public interface IMovieCategoryService
    {
        List<MovieCategory> GetAllMovieCategories();
        MovieCategory GetMovieCategoryByMovieCategoryName(string movieCategoryName);
        MovieCategory AddMovieCategory(MovieCategory movieCategory);
        MovieCategory UpdateMovieCategory(MovieCategory movieCategory);
        void DeleteMovieCategory(MovieCategory movieCategory);
    }
}
