using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Application
{
    public interface IMovieService
    {
        public List<Movie> GetallMovies();
        public Movie CreateMovie(Movie movie);
    }
}
