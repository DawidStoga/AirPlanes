using System;
using System.Collections.Generic;
using System.Text;

namespace Features
{
   public class Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public string MetaClass { get; set; }

        public string Catalog { get; set; }

        public Metafields Metafields { get; set; }
        public SeoInformation[] SeoInformations { get; set; }

        public object Prices { get; set; }

        public Node[] Nodes { get; set; }

    }

    public class Node
    {
    }

    public class SeoInformation
    {
        public string Titile { get; set; }
        public string Uri { get; set; }
        public string UriSegment { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }

        public string LanguageCode { get; set; }
    }

    public class Metafields
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Data[] Datas { get; set; }
    }

    public class Data
    {
        public string Language { get; set; }
        public string Value { get; set; }
    }
}
