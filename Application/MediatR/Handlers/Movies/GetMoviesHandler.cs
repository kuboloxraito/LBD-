using Application.DTO;
using Application.Interfaces;
using Application.MediatR.Queries.Movies;
using MediatR;

namespace Application.MediatR.Handlers.Movies
{
    public class GetMoviesHandler : IRequestHandler<GetMoviesQuery, List<MovieDTO>>
    {
        private readonly IMovieService _service;

        public GetMoviesHandler(IMovieService service)
        {
            _service = service;
        }

        public async Task<List<MovieDTO>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetMovies(request.page).Result);
        }
    }
}