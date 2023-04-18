using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntertainmentApp.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entertainment_app.Controllers
{
    [Route("/entertainment/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public TvShowsController (DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllTvShows()
            => Ok(_dbContext.TvShows.ToList());

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTvShowById(int id)
        {
            var tvShow = _dbContext.TvShows.Where(x => x.Id == id);

            if (tvShow.Any())
            {
                return Ok(tvShow);
            }

            return BadRequest($"No tvShow found with ID {id}.");
        }

        [HttpGet("top-rated")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetTopRated()
            => Ok(_dbContext.TvShows.OrderByDescending(x => x.VoteCount).ThenByDescending(x => x.VoteAverage).Take(5).ToList());

        [HttpGet("popular")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetPopular()
            => Ok(_dbContext.TvShows.OrderByDescending(x => x.Popularity).Take(5).ToList());

        [HttpGet("language/{language:length(2)}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetByLanguage(string language)
        {
            var TvShows = _dbContext.TvShows.Where(x => x.OriginalLanguage == language);

            if (TvShows.Any())
            {
                return Ok(TvShows.ToList());
            }

            return BadRequest($"No shows found in the language {language}.");
        }
    }
}
