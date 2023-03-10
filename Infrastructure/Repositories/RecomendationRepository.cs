using DataAccess.Interfaces;
using DataAccess.Models;

namespace Infrastructure.Repositories
{
    public class RecomendationRepository : IRecomendationRepository
    {
        private readonly DatabaseContext _databaseContext;

        public RecomendationRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Recomendation> GetRecommendation(int movieId)
        {
            return _databaseContext.recomendation.Where(x => x.MovieId == movieId).FirstOrDefault();
        }

        public async Task<int> ToggleForMovie(int movieId)
        {
            Recomendation? recommendation = _databaseContext.recomendation.FirstOrDefault(r => r.MovieId == movieId);

            if (recommendation is null)
            {
                Recomendation newRecommendation = new Recomendation()
                {
                    MovieId = movieId,
                    IsRecommended = true
                };
                _databaseContext.Add(newRecommendation);
            }
            else
            {
                recommendation.IsRecommended = !recommendation.IsRecommended;
                _databaseContext.Update(recommendation);
            }

            _databaseContext.SaveChanges();
            return movieId;
        }
    }
}