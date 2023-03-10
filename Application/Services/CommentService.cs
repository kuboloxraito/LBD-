using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            this._commentRepository = commentRepository;
            this._mapper = mapper;
        }

        public async Task<Comment> AddComment(CommentDTO commentdto)
        {
            Comment comment = _mapper.Map<Comment>(commentdto);

            return await _commentRepository.AddComment(comment);
        }

        public async Task<List<Comment>> GetCommentsByMovieId(int movieId)
        {
            return await _commentRepository.GetCommentsByMovie(movieId);
        }
    }
}