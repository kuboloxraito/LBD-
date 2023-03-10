using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IMapper _mapper;

        public RatingService(IRatingRepository ratingRepository, IMapper mapper)
        {
            this._ratingRepository = ratingRepository;
            this._mapper = mapper;
        }

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task<Rating> AddRatingToMovieId(RatingDTO ratingDto)
        {
            Rating rating = _mapper.Map<Rating>(ratingDto);

            return await _ratingRepository.AddRatingToMovieId(rating);
        }

        public async Task<List<Rating>> GetRatingsByMovieId(int movieId)
        {
            return await _ratingRepository.GetRatingsByMovieId(movieId);
        }
    }
}