using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ang3.Models;
using Ang3.Repo;

namespace Ang3.Controllers
{
    public class PlanesController : ApiController
    {
        // GET api/<controller>
        public IList<Plane> Get()
        {

            return   Repository.GetAllPlanes();

            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}