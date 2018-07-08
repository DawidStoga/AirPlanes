using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Features
{
    public class Json
    {
        public void TestJson()
        {
            Product product = new Product
            {
                Name = "Name",
                TechData1 = "d2"
            };



            string json =
                JsonConvert.SerializeObject(
                    product,
                    Formatting.Indented,
                    new JsonSerializerSettings { /*ContractResolver = new CamelCasePropertyNamesContractResolver()*/ }
                    );
        }
    }
}

