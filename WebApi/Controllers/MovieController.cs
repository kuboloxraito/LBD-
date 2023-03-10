using Application.DTO;
using Application.MediatR.Queries.Movies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("movie")]
        public async Task<ActionResult<MovieDTO>> GetMovieByID([FromQuery] int id)
        {
            try
            {
                return Ok(await _mediator.Send(new GetMovieByIdQuery(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("popular")]
        public async Task<ActionResult<List<MovieDTO>>> GetMovies([FromQuery] int page)
        {
            try
            {
                return Ok(await _mediator.Send(new GetMoviesQuery(page)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetMoviesByTitle")]
        public async Task<ActionResult<List<MovieDTO>>> GetMoviesByTitle([FromQuery] string keyWord)
        {
            try
            {
                return Ok(await _mediator.Send(new GetMoviesByTitleQuery(keyWord)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}