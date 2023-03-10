namespace Application.Api
{
    public class ApiEndpoints
    {
        private static readonly string BaseUrl = "https://api.themoviedb.org/3";
        private static readonly string ApiKey = "?api_key=c8e07639d39cf507a8ff31431db9cd7c";

        public static string GetMovieId(int id) => $"{BaseUrl}/movie/{id}{ApiKey}";

        public static string GetMovies(int pagenumber) => $"{BaseUrl}/movie/popular{ApiKey}&page={pagenumber}";

        public static string GetSearchedMovies(string search) => $"{BaseUrl}/search/movie{ApiKey}&query={search}";
    }
}