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
                cfg => {
                    cfg.AddProfile<AppProfile>();

                });

            //   var mapper1 = config.CreateMapper(); 
            //or
             
            config.AssertConfigurationIsValid();

            IMapper mapper = new Mapper(config);
           // Mapper.Configuration.AssertConfigurationIsValid();

            return mapper;
        }

    }
}