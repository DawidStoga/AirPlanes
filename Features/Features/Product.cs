using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Features
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Product:ProductBase
    {
        [JsonIgnore]
        public string Name { get; set; }
        public string TechData1 { get; set; }
        public string TechData2 { get; set; }
        public string TechData3 { get; set; }
        public string TechData4 { get; set; }
        public string TechData5 { get; set; }

    }

    public class ProductBase
    {
        
        public string TechDataA { get; set; }
        public string TechDataB { get; set; }
        public string TechDataC { get; set; }
        public string TechDataD { get; set; }
        public string TechDataE { get; set; }

    }

}
