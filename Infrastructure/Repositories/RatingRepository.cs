using DataAccess.Interfaces;
using DataAccess.Models;

namespace Infrastructure.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DatabaseContext _databaseContext;

        public RatingRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Rating> AddRatingToMovieId(Rating rating)
        {
            _databaseContext.rating.Add(rating);
            _databaseContext.SaveChanges();
            return await Task.FromResult(rating);
        }

        public async Task<List<Rating>> GetRatingsByMovieId(int movieId)
        {
            return _databaseContext.rating.Where(r => r.MovieId == movieId).ToList();
        }
    }
}