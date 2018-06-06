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
            return mapper.Map<Aircraft, Machine>(airplane);
        }

    }
}