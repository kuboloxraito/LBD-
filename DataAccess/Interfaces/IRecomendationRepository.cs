using DataAccess.Models;

namespace DataAccess.Interfaces
{
    public interface IRecomendationRepository
    {
        Task<int> ToggleForMovie(int movieId);

        Task<Recomendation> GetRecommendation(int movieId);
    }
}