using Application.DTO;

namespace Application.Interfaces
{
    public interface IMovieService
    {
        public Task<MovieDTO> GetMovieById(int id);

        public Task<List<MovieDTO>> GetMovies(int page);

        public Task<List<MovieDTO>> GetMoviesByTitle(string keyWord);
    }
}