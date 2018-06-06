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
            CreateMap<Machine, Aircraft>();
            CreateMap<Aircraft, Machine>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.AircraftID));
        }
      
    }
}