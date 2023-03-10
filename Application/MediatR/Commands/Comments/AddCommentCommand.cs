using Application.DTO;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Commands.Comments
{
    public record AddCommentCommand(CommentDTO commentdto) : IRequest<Comment>;
}