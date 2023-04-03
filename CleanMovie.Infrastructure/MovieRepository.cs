using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id=1, Name="Avatar" , Cost=100},
            new Movie{Id=2,Name="Chalk Line",Cost=200}
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
