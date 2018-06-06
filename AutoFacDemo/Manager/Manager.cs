using AutoFacDemo.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Manager
{
    public class Manager
    {
        protected IMapper mapper;
        public Manager(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public Machine GetMachine()
        {
            var airplane = Repository.Repository.GetAircraft();
            var tets = mapper.Map<Machine>(airplane);

            var source = new Source()
            {
                Name = "DAWID",
                Category = "POL"
            };

            var result = mapper.Map<Source, Destination>(source);
            var dest = mapper.Map<Source, Destination>(source, opts => opts.ConfigureMap().ForMember(des =>des.Namess, m => m.MapFrom(src => src.Name  + " Stoga")));

            var nestedSource = new OuterSource
            {
                value1 = 1,
                value4 = 4,
                value2 = new InnerSource
                {
                    value3 = 3
                }
            };

            var nestedSource2 = new ParentSource
            {
                value4 = 5
            };

           // var nestedDest2 = mapper.Map<OuterDest>(nestedSource2);
            var nestedDest = mapper.Map<OuterDest>(nestedSource);

            return mapper.Map<Aircraft, Machine>(airplane);
        }

    }
}