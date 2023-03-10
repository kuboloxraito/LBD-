using Application.Interfaces;
using Application.MediatR.Commands.Ratings;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Handlers.Ratings
{
    public class AddRatingToMovieIdHandler : IRequestHandler<AddRatingToMovieIdCommand, Rating>
    {
        private readonly IRatingService _service;

        public AddRatingToMovieIdHandler(IRatingService service)
        {
            _service = service;
        }

        public async Task<Rating> Handle(AddRatingToMovieIdCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.AddRatingToMovieId(request.ratingDto).Result);
        }
    }
}