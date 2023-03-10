namespace DataAccess.Models
{
    public class Recomendation
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public bool IsRecommended { get; set; }
    }
}