using Application.DTO;
using Application.MediatR.Commands.Ratings;
using Application.MediatR.Queries.Ratings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RatingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("addrating")]
        public async Task<IActionResult> AddRatingByMovieId([FromQuery] RatingDTO ratingDTO)
        {
            try
            {
                return Ok(_mediator.Send(new AddRatingToMovieIdCommand(ratingDTO)).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getrating")]
        public async Task<IActionResult> GetRatingByMovieId(int movieId)
        {
            try
            {
                return Ok(_mediator.Send(new GetRatingsByMovieIdQuery(movieId)).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}