using Application.Interfaces;
using Application.MediatR.Commands.Comments;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Handlers.Comments
{
    public class AddCommentHandler : IRequestHandler<AddCommentCommand, Comment>
    {
        private readonly ICommentService _service;

        public AddCommentHandler(ICommentService service)
        {
            _service = service;
        }

        public async Task<Comment> Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_service.AddComment(request.commentdto).Result);
        }
    }
}