﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEAAS.Business.Abstract;
using MEAAS.DataAccess.Abstract;
using MEAAS.Entities.Concrete;

namespace MEAAS.Business.Concrete.Managers
{
    public class MovieManager:IMovieService
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDal.GetAll();
        }

        public List<Movie> GetMoviesByTitle(string movieTitle)
        {
            return _movieDal.GetAll(u => u.MovieTitle.ToLower().Contains(movieTitle.ToLower()));
        }

        public Movie GetMovieByTitle(string movieTitle)
        {
            return _movieDal.Get(m => m.MovieTitle.Equals(movieTitle)); ;
        }

        public Movie AddMovie(Movie movie)
        {
            return _movieDal.Add(movie);
        }

        public Movie UpdateMovie(Movie movie)
        {
            return _movieDal.Update(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            _movieDal.Delete(movie);
        }
    }
}
