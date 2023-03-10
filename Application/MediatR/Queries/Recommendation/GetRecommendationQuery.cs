using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Queries.Recommendation
{
    public record GetRecommendationQuery(int movieId) : IRequest<Recomendation>;
}