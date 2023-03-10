using Application.DTO;
using MediatR;

namespace Application.MediatR.Queries.Movies
{
    public record GetMoviesQuery(int page) : IRequest<List<MovieDTO>>;
}