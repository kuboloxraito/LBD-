using Application.DTO;
using Application.Interfaces;
using Application.MediatR.Queries.Movies;
using MediatR;

namespace Application.MediatR.Handlers.Movies
{
    public class GetMoviesByTitleHandler : IRequestHandler<GetMoviesByTitleQuery, List<MovieDTO>>
    {
        private readonly IMovieService _service;

        public GetMoviesByTitleHandler(IMovieService service)
        {
            _service = service;
        }

        public async Task<List<MovieDTO>> Handle(GetMoviesByTitleQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetMoviesByTitle(request.keyWord).Result);
        }
    }
}