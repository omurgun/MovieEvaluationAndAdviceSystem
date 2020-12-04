using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MEAAS.Business.Abstract;
using MEAAS.Business.DependencyResolvers.Ninject;
using MEAAS.Entities.Concrete;

namespace MEASS.MvcWebUI.Controllers.Admin
{
    public class AdminMovieOperationsController : Controller
    {
        private readonly IMovieService _movieService = InstanceFactory.GetInstance<IMovieService>();
        // GET: AdminMovieOperations
        public ActionResult Index()
        {
            return View();
        }

        public List<Movie> AllMovies()
        {
            return _movieService.GetAllMovies();
        }
        public string AddMovie()
        {
            try
            {
                var title = "hızlı ve öfkeli";
                var category = "1";
                var thumbnailUrl = "url";


                if (title == string.Empty || category == string.Empty || thumbnailUrl == string.Empty)
                {
                   return "can't be blank";
                }
                else
                {
                    var movie = _movieService.GetMovieByTitle(title);
                    if (movie == null)
                    {
                        var savedMovie = _movieService.AddMovie(new Movie
                        {
                            MovieTitle = title,
                            MovieThumbnail = thumbnailUrl,
                            MovieCategoryId = Convert.ToInt32(category)
                        });
                        if (savedMovie != null)
                        {
                            return "new movie added.";
                        }
                        else
                        {
                            return "Couldn't add new movie!!";
                        }
                    }
                    else
                    {
                        return "this movie has already been added";
                    }
                }

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMovie()
        {
            try
            {
                var updateTitle = "hızlı ve öfkeli";
                var updateCategory = "1";
                var updateThumbnailUrl = "urlurl";


                if (updateTitle == string.Empty || updateCategory == string.Empty || updateThumbnailUrl == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var movie = _movieService.GetMovieByTitle(updateTitle);
                    if (movie != null)
                    {
                        var updatedMovie = _movieService.UpdateMovie(new Movie
                        {
                            Id = movie.Id,
                            MovieTitle = updateTitle,
                            MovieThumbnail = updateThumbnailUrl,
                            MovieCategoryId = Convert.ToInt32(updateCategory)
                        });
                        if (updatedMovie != null)
                        {
                            return "movie updated.";
                        }
                        else
                        {
                            return "Couldn't update movie!!";
                        }

                    }
                    else
                    {
                        return "There is no such movie";
                    }
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string DeleteMovie()
        {
            try
            {
                _movieService.DeleteMovie(new Movie
                {
                    Id = 1
                });
                return "Movie Deleted!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
            
        }
        public string SearchByMovieTitle()
        {
            return _movieService.GetMoviesByTitle("title").ToString();
        }

    }
}