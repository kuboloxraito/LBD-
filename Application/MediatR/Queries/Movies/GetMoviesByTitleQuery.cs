using Application.DTO;
using MediatR;

namespace Application.MediatR.Queries.Movies
{
    public record GetMoviesByTitleQuery(string keyWord) : IRequest<List<MovieDTO>>;
}