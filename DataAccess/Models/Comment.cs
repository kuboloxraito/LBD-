namespace DataAccess.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Comments { get; set; }
        public DateTime CreatedDate { get; set; }

        public int MovieId { get; set; }

        public Comment()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}