using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Newtonsoft.Json;
namespace Features
{
    class Program
    {
        static IMapper mapper;
        static void Main(string[] args)
        {
         mapper =    Initiate.Configure();

            //var s1 = "Hervé UK Ålesund i Sunnmøreå, ø, æPOL";
            //var s2 = "Ålesund i Sunnmøreå, ø, æ";

            //var sc1 = s1.ResolveAcronyms().ReplaceDiacriticChars(TranslateHelperClass.charDict);


          


            POCO poco = new POCO
            {
                Address = "Litewska",
                Name = "dawid"
            };


            TechnicalDetails details = new TechnicalDetails();
            details.data = "Product";
            details.value = JsonConvert.SerializeObject(poco);

            var output = JsonConvert.SerializeObject(details);




            Product product = new Product
            {
                Name = "productName",
                TechData1 = "dataA",
                TechData2 = "dataB",
                TechData3 = "dataC",
                TechData4 = "dataD",
                TechData5 = "dataE",

            };


            Manager manager = new Manager(mapper);
            var enity = manager.FillEnity(product);

            Console.ReadKey();
        }


 
    }


    public class POCO
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class TechnicalDetails
    {
        public string data { get; set; }
        public string value { get; set; }
    }



   






    public static class TranslateHelperClass
    {

 


        private static readonly Dictionary<string, string> abbr;
        public static readonly Dictionary<char, string> charDict;
        static TranslateHelperClass()
        {
            abbr = new Dictionary<string, string>
            {
                { "UK", "United Kindgdom" },
                { "PL", "Poland" }
            };
            charDict = new Dictionary<char, string>
            {
                {'å', "YY" }
            };
        }





       private static string TryResolveAcronym(string input)
        {
            return abbr.ContainsKey(input) ? abbr[input] : input;
        }
       private static string TryTranslateChar(char letter)
        {
            return charDict.ContainsKey(letter) ? charDict[letter]  : letter.ToString();
        }


        public static string ReplaceDiacriticChars(this string text, Dictionary<char, string> dictionary)
        {           
         return  string.Join("", text.Select(x => dictionary.ContainsKey(x) ? dictionary[x] : x.ToString()));
        }

        public static string ReplaceDiacriticChars(this string text)
        {
            return new string(text.Normalize(System.Text.NormalizationForm.FormD).Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark).ToArray());
        }


        public static string ResolveAcronyms(this string text)
        {
            var words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return words.Aggregate((translated, next) => string.Join(" ", translated, TryResolveAcronym(next)));
        }



    }


}
