using Application.DTO;
using DataAccess.Models;

namespace Application.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> AddComment(CommentDTO comment);

        Task<List<Comment>> GetCommentsByMovieId(int movieId);
    }
}