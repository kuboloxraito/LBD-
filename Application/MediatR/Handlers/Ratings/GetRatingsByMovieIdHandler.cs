using Application.Interfaces;
using Application.MediatR.Queries.Ratings;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Handlers.Ratings
{
    public class GetRatingsByMovieIdHandler : IRequestHandler<GetRatingsByMovieIdQuery, List<Rating>>
    {
        private readonly IRatingService _service;

        public GetRatingsByMovieIdHandler(IRatingService service)
        {
            _service = service;
        }

        public async Task<List<Rating>> Handle(GetRatingsByMovieIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetRatingsByMovieId(request.movieId).Result);
        }
    }
}