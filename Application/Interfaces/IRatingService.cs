using Application.DTO;
using DataAccess.Models;

namespace Application.Interfaces
{
    public interface IRatingService
    {
        Task<Rating> AddRatingToMovieId(RatingDTO ratingDto);

        Task<List<Rating>> GetRatingsByMovieId(int movieId);
    }
}