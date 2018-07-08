using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Features
{
    public class Manager
    {
        private readonly IMapper mapper;
        public Manager(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public Entity FillEnity(Product product)
        {

           return  mapper.Map<Product, Entity>(product);
        }
    }
}
