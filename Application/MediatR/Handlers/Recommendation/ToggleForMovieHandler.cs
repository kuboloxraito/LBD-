using Application.Interfaces;
using Application.MediatR.Commands.Recommendation;
using MediatR;

namespace Application.MediatR.Handlers.Recommendation
{
    public class ToggleForMovieHandler : IRequestHandler<ToggleForMovieCommand, bool>
    {
        private readonly IRecomendationService _service;

        public ToggleForMovieHandler(IRecomendationService service)
        {
            _service = service;
        }

        public Task<bool> Handle(ToggleForMovieCommand request, CancellationToken cancellationToken)
        {
            _service.ToggleForMovie(request.movieId);
            return Task.FromResult(true);
        }
    }
}