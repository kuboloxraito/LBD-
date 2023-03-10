using Application.DTO;
using MediatR;

namespace Application.MediatR.Queries.Movies
{
    public record GetMovieByIdQuery(int id) : IRequest<MovieDTO>;
}