using Newtonsoft.Json;

namespace Application.DTO
{
    public class MoviesListDTO
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<MovieDTO> movies { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }
}