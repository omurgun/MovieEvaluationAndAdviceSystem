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
        private readonly IMovieCategoryService _movieCategoryService = InstanceFactory.GetInstance<IMovieCategoryService>();

        // GET: AdminMovieOperations
        public ActionResult Index()
        {
            return View();
        }

        // movie operations
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

        // movie category operations
        public List<MovieCategory> AllMovieCategories()
        {
            return _movieCategoryService.GetAllMovieCategories();
        }
        public string AddMovieCategory()
        {
            try
            {
                var name = "Horror";

                if (name == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
                    if (movieCategory == null)
                    {
                        var savedMovieCategory = _movieCategoryService.AddMovieCategory(new MovieCategory
                        {
                            MovieCategoryName = name
                        });
                        if (savedMovieCategory != null)
                        {
                            return "new movie category added.";
                        }
                        else
                        {
                            return "Couldn't add new movie category!!";
                        }
                    }
                    else
                    {
                        return "this movie category has already been added";
                    }
                }

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMovieCategory()
        {
            try
            {
                var name = "Actionn";

                if (name == string.Empty)
                {
                    return "can't be blank";
                }
                else
                {
                    var movieCategory = _movieCategoryService.GetMovieCategoryByMovieCategoryName(name);
                    var updatedMovieCategory = _movieCategoryService.UpdateMovieCategory(new MovieCategory
                    {
                        MovieCategoryId = 1,
                        MovieCategoryName = name
                    });
                    if (updatedMovieCategory != null)
                    {
                        return "movie category updated.";
                    }
                    else
                    {
                        return "Couldn't update movie category!!";
                    }
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string DeleteMovieCategory()
        {
            try
            {
                _movieCategoryService.DeleteMovieCategory(new MovieCategory
                {
                    MovieCategoryId = 2
                });
                return "Movie Category Deleted!";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        public string SearchByMovieCategoryName()
        {
            return _movieCategoryService.GetMovieCategoriesByCategoryName("name").ToString();
        }

    }
}