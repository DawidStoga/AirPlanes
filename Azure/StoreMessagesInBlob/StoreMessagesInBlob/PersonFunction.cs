
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Threading.Tasks;
using AzureFunctions.Autofac;
using AutofacDIExample;
using StoreMessagesInBlob.DependencyInjector.Attributes;
using AutofacDIExample.Resolvers;
using StoreMessagesInBlob.Service;
using StoreMessagesInBlob.Model;

namespace StoreMessagesInBlob
{
    [DependencyInjectionConfig(typeof(DIConfig))]
    public static class PersonFunction
    {
        [FunctionName("PersonFunction")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
        HttpRequest req,
        TraceWriter log,
        [Inject("Main")] IGoodbyer godbye,
        [Inject("Secondary")] IGoodbyer Say

        )
        {
            log.Info("C# HTTP trigger function processed a request.");
            Customer customer3;
            var content = await req.ReadAsStringAsync();

           
            string requestBody = new StreamReader(req.Body).ReadToEnd();
            customer3 = JsonConvert.DeserializeObject<Customer>(requestBody);
            string name = req.Query["name"];

            Person person = new Person();
            name += ValidatorFactory.GetValidator(person).Validate(person);

            Customer customer = new Customer();
            name += ValidatorFactory.GetValidator(customer3).Validate(customer3);

            Person person2 = new Person();
            name +=  new ValidatorFactory().GetValidator<Person>().Validate(person2);

            name +=  ValidatorFactory.GetStaticValidator<Person>().Validate(person2);
            dynamic data = "";
          
            name = name ?? data?.name;

            name = godbye.Goodbye();
            var name2 = Say.Goodbye();
            return name != null
                ? (ActionResult)new OkObjectResult($"Hello, {name} Whats: {name2}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
