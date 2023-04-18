using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EntertainmentApp.Helpers;

namespace entertainment_app.Controllers
{
    [Route("/entertainment/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public MoviesController (DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllMovies()
            => Ok(_dbContext.Movies.ToList());

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMovieById(int id)
        {
            var movie = _dbContext.Movies.Where(x => x.Id == id);

            if (movie.Any())
            {
                return Ok(movie);
            }

            return BadRequest($"No movie found with ID {id}.");
        }

        [HttpGet("top-rated")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetTopRated()
            => Ok(_dbContext.Movies.OrderByDescending(x => x.VoteCount).ThenByDescending(x => x.VoteAverage).Take(5).ToList());

        [HttpGet("popular")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetPopular()
            => Ok(_dbContext.Movies.OrderByDescending(x => x.Popularity).Take(5).ToList());

        [HttpGet("language/{language:length(2)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByLanguage(string language)
        {
            var movies = _dbContext.Movies.Where(x => x.OriginalLanguage == language);

            if (movies.Any())
            {
                return Ok(movies.ToList());
            }

            return BadRequest($"No movies found in the language {language}.");
        }
    }
}
