using Application.DTO;
using Application.Interfaces;
using Application.MediatR.Queries.Movies;
using MediatR;

namespace Application.MediatR.Handlers.Movies
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieDTO>
    {
        private readonly IMovieService _service;

        public GetMovieByIdHandler(IMovieService service)
        {
            _service = service;
        }

        public async Task<MovieDTO> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetMovieById(request.id).Result);
        }
    }
}