using DataAccess.Interfaces;
using DataAccess.Models;

namespace Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly DatabaseContext _databaseContext;

        public CommentRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Comment>> GetCommentsByMovie(int movieId)
        {
            return _databaseContext.comment.Where(comment => comment.MovieId == movieId).DefaultIfEmpty().ToList();
        }

        public Task<Comment> AddComment(Comment comment)
        {
            _databaseContext.comment.Add(comment);
            _databaseContext.SaveChanges();
            return Task.FromResult(comment);
        }
    }
}