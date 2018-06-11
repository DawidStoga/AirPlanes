using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ang3.Models
{
    public class Plane
    {
        [JsonProperty("id", Required = Required.Always)]
        public int id { get; set; }
        [JsonProperty("name", Required = Required.Always)]
        public string name { get; set; }
        [JsonProperty("Smodel", Required = Required.Always)]
        public string Smodel { get; set; }
        [JsonProperty("Stype", Required = Required.Always)]
        public string Stype { get; set; }
    }
}

//export class Machine
//{
//    id: number;
//    name: string;
//    Smodel: string;
//    Stype: string;
    
//}