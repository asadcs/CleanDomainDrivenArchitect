using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _IMovieService;
        public MoviesController(IMovieService IMovieService)
        {
            _IMovieService = IMovieService;
        }


        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _IMovieService.GetallMovies();
            return Ok(moviesFromService);
        }

        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            _IMovieService.CreateMovie(movie);
            return Ok(movie);
        }

        // GET api/<MoviesController>/5
    }
}
