using System;
using System.Collections.Generic;
using System.Text;
using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie>GetAllMovies();
    }
}
