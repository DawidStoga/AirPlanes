using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Features
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
     
            CreateMap<Product, Metafields>()
                .ForMember(d => d.Name, opt => opt.UseValue("TechnicalSpecification"))
                .ForMember(d => d.Type, opt => opt.UseValue("LongString"))
                .ForMember(d => d.Datas, opt => opt.ResolveUsing(new TechResolver()));
           CreateMap<Product, Entity>(MemberList.None)
                .ForMember(d=>d.Metafields, )
            //CreateMap<Aircraft, Machine>()
            //    .ForMember(d => d.Id, opt => opt.MapFrom(src => src.AircraftID)).ReverseMap();
            //CreateMap<Source, Destination>(MemberList.None);

            //CreateMap<ParentSource, ParentDest>();
            //CreateMap<OuterSource, OuterDest>()
            //    .ForMember(dest => dest.Total, opt => opt.ResolveUsing(new CustomResolver()));


            //CreateMap<InnerSource, InnerDest>();

        }

    }

    public class TechResolver : IValueResolver<Product, Metafields, Data[]>
    {
        public Data[] Resolve(Product source, Metafields destination, Data[] destMember, ResolutionContext context)
        {
            Data[] data = new Data[2];

            data[0].Language = "en";
            data[0].Value = JsonConvert.SerializeObject(source);
            data[0].Language = "no";
            data[1] = data[0];

return data;
        }
    }
    //public class CustomResolver : IValueResolver<OuterSource, OuterDest, int>
    //{
    //    public int Resolve(OuterSource source, OuterDest destination, int member, ResolutionContext context)
    //    {
    //        return source.value1 + source.value4;
    //    }
    //}
}
