using Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.Controllers.API
{
    public class MetadataController : ApiController
    {
        // GET: api/Metadata
        public IEnumerable<string> Get()
        {
            return new string[] { "Vishnu S", "Software Engineer" };
        }

        // GET: api/Metadata/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Metadata
        public bool Post(Credential credential)
        {
            if (credential.Username.Equals("user") && credential.Password.Equals("pass"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // PUT: api/Metadata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Metadata/5
        public void Delete(int id)
        {
        }
    }
}
