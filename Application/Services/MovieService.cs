using Application.Api;
using Application.DTO;
using Application.Interfaces;
using System.Web.Http;

namespace Application.Services
{
    public class MovieService : IMovieService
    {
        public async Task<MovieDTO> GetMovieById(int id)
        {
            ApiHelpers.InitializeClient();

            string URL = ApiEndpoints.GetMovieId(id);

            using HttpResponseMessage responseMessage = await ApiHelpers.ApiClient.GetAsync(URL);

            if (responseMessage.IsSuccessStatusCode)
            {
                MovieDTO movie = await responseMessage.Content.ReadAsAsync<MovieDTO>();
                return movie;
            }
            else
            {
                throw new Exception(responseMessage.ReasonPhrase);
            }
        }

        public async Task<List<MovieDTO>> GetMovies(int page)
        {
            ApiHelpers.InitializeClient();

            string url = ApiEndpoints.GetMovies(page);

            using HttpResponseMessage response = await ApiHelpers.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var moviesDto = await response.Content.ReadAsAsync<MoviesListDTO>();
                return moviesDto.movies;
            }
            else
            {
                response.Content = new StringContent($"No movies found");
                response.ReasonPhrase = "Movies not found";
                throw new HttpResponseException(response);
            }
        }

        public async Task<List<MovieDTO>> GetMoviesByTitle(string keyWord)
        {
            ApiHelpers.InitializeClient();

            string url = ApiEndpoints.GetSearchedMovies(keyWord);

            using HttpResponseMessage response = await ApiHelpers.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var moviesDto = await response.Content.ReadAsAsync<MoviesListDTO>();
                return moviesDto.movies;
            }
            else
            {
                response.Content = new StringContent($"No movies found");
                response.ReasonPhrase = "Movies not found";
                throw new HttpResponseException(response);
            }
        }
    }
}