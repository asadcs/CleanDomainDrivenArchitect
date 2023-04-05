using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
       

        private readonly MovieDBContext _movieDBContext;


        public MovieRepository(MovieDBContext movieDBContext)
        {
            _movieDBContext = movieDBContext;
        }


        public Movie CreateMovie(Movie movie)
        {
            _movieDBContext.Movies.Add(movie);
            _movieDBContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDBContext.Movies.ToList();
        }
    }
}
