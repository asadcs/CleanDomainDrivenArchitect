using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService
    {
        public IMovieRepository _IMovieRepository { get; }

        public MovieService(IMovieRepository IMovieRepository)
        {
            _IMovieRepository = IMovieRepository;
        }


        public List<Movie> GetallMovies()
        {
            var movies = _IMovieRepository.GetAllMovies();
            return movies;
        }

        public Movie CreateMovie(Movie movie)
        {
            _IMovieRepository.CreateMovie(movie);
            return movie;
        }
    }
}
