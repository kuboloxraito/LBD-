using Application.Interfaces;
using AutoMapper;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace Application.Services
{
    public class RecommendationService : IRecomendationService
    {
        private readonly IRecomendationRepository _recomendationRepository;

        public RecommendationService(IRecomendationRepository recomendationRepository, IMapper mapper)
        {
            _recomendationRepository = recomendationRepository;
        }

        public async Task<Recomendation> GetRecomendation(int movieId)
        {
            return await _recomendationRepository.GetRecommendation(movieId);
        }

        public async Task ToggleForMovie(int movieId)
        {
            _recomendationRepository.ToggleForMovie(movieId);
        }
    }
}