using Application.Interfaces;
using Application.MediatR.Queries.Comments;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Handlers.Comments
{
    public class GetCommentsByMovieIdHandler : IRequestHandler<GetCommentsByMovieIdQuery, List<Comment>>
    {
        private readonly ICommentService _service;

        public GetCommentsByMovieIdHandler(ICommentService service)
        {
            _service = service;
        }

        public async Task<List<Comment>> Handle(GetCommentsByMovieIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetCommentsByMovieId(request.movieId).Result);
        }
    }
}