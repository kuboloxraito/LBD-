using Application.MediatR.Commands.Recommendation;
using Application.MediatR.Queries.Recommendation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecommendationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("recommendation")]
        public async Task<IActionResult> ToggleForMovieRecommendation([FromQuery] int movieId)
        {
            try
            {
                return Ok(_mediator.Send(new ToggleForMovieCommand(movieId)).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("recommendation/get")]
        public async Task<IActionResult> GetRecommendation(int movieId)
        {
            try
            {
                return Ok(_mediator.Send(new GetRecommendationQuery(movieId)).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}