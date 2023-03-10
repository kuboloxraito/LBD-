using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Queries.Comments
{
    public record GetCommentsByMovieIdQuery(int movieId) : IRequest<List<Comment>>;
}