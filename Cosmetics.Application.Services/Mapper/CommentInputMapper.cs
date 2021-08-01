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
            CreateMap<CommentInputDto, Comment>();
                                              

            //Mapper.CreateMap<Year, YearViewModel>();
            //AutoMapper.Mapper.CreateMap<Month, MonthViewModel>()
            //     .ForMember(a => a.YearViewModel, b => b.ResolveUsing(c => c.Year));

        }
    }
}
