using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Queries.Ratings
{
    public record GetRatingsByMovieIdQuery(int movieId) : IRequest<List<Rating>>;
}