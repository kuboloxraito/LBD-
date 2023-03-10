using Application.Interfaces;
using Application.MediatR.Queries.Recommendation;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Handlers.Recommendation
{
    public class GetRecommendationHandler : IRequestHandler<GetRecommendationQuery, Recomendation>
    {
        private readonly IRecomendationService _service;

        public GetRecommendationHandler(IRecomendationService service)
        {
            _service = service;
        }

        public async Task<Recomendation> Handle(GetRecommendationQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.GetRecomendation(request.movieId).Result);
        }
    }
}