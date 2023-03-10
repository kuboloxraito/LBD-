using Application.DTO;
using DataAccess.Models;
using MediatR;

namespace Application.MediatR.Commands.Ratings
{
    public record AddRatingToMovieIdCommand(RatingDTO ratingDto) : IRequest<Rating>;
}