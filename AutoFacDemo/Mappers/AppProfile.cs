using AutoFacDemo.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Mappers
{
    public class AppProfile:Profile
    {
        public AppProfile()
        {
            //  CreateMap<Machine, Aircraft>(MemberList.Destination);

            CreateMap<Aircraft, Machine>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.AircraftID)).ReverseMap();
            CreateMap<Source, Destination>(MemberList.None);

            CreateMap<ParentSource, ParentDest>();
            CreateMap<OuterSource, OuterDest>()
                .ForMember(dest => dest.Total, opt => opt.ResolveUsing(new CustomResolver()));


            CreateMap<InnerSource, InnerDest>();

        }
      
    }

    public class CustomResolver : IValueResolver<OuterSource, OuterDest, int>
    {
        public int Resolve(OuterSource source, OuterDest destination, int member, ResolutionContext context)
        {
            return source.value1 + source.value4;
        }
    }
}