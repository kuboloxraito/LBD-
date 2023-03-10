using DataAccess.Models;

namespace DataAccess.Interfaces
{
    public interface IRatingRepository
    {
        Task<Rating> AddRatingToMovieId(Rating rating);

        Task<List<Rating>> GetRatingsByMovieId(int movieId);
    }
}