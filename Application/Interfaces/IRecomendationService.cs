using DataAccess.Models;

namespace Application.Interfaces
{
    public interface IRecomendationService
    {
        Task ToggleForMovie(int movieId);

        Task<Recomendation> GetRecomendation(int movieId);
    }
}