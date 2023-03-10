namespace DataAccess.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int Rate { get; set; }
    }
}