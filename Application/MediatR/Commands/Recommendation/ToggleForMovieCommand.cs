using MediatR;

namespace Application.MediatR.Commands.Recommendation
{
    public record ToggleForMovieCommand(int movieId) : IRequest<bool>;
}