using DataAccess.Models;

namespace DataAccess.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> AddComment(Comment comment);

        Task<List<Comment>> GetCommentsByMovie(int movieId);
    }
}