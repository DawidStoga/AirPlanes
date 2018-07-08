using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Features
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
