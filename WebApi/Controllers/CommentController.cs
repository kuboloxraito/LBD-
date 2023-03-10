using Application.DTO;
using Application.MediatR.Commands.Comments;
using Application.MediatR.Queries.Comments;
using DataAccess.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("comment")]
        public async Task<ActionResult<List<Comment>>> GetCommentByMovieId([FromQuery] int id)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCommentsByMovieIdQuery(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addcomment")]
        public async Task<ActionResult<CommentDTO>> AddComment([FromQuery] CommentDTO comment)
        {
            return Ok(await _mediator.Send(new AddCommentCommand(comment)));
        }
    }
}