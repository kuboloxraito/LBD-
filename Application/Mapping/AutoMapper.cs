using Application.DTO;
using AutoMapper;
using DataAccess.Models;

namespace Application.Mapping
{
    public class AutoMapper
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CommentDTO, Comment>(MemberList.Source);
            cfg.CreateMap<RatingDTO, Rating>(MemberList.Source);
        }
    }
}