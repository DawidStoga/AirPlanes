using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace AutoFacDemo.Mappers
{
    public static class Initiate
    {
    public static IMapper Configure()
        {
            var config = new MapperConfiguration(
                cfg => { cfg.AddProfile<AppProfile>(); });

            IMapper mapper = new Mapper(config);
           
            return mapper;
        }

    }
}