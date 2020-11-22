using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        List<Movie> GetMoviesByTitle(string movieTitle);
        Movie GetMovieByTitle(string movieTitle);
        Movie AddMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        void DeleteMovie(Movie movie);
    }
}
