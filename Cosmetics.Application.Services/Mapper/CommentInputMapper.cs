using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class CommentInputMapper: Profile
    {
        public CommentInputMapper()
        {
            //CreateMap<CommentInputDto, Comment>().ForMember(x => x.User.Name, o => o.MapFrom(y => y.Name))
            //                                 .ForMember(x => x.User.Family, o => o.MapFrom(y => y.Family))
            //                                  .ForMember(x => x.Product.Id, o => o.MapFrom(y => y.ProductId));

        }
    }
}
