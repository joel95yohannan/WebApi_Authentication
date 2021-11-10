using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Authorize(Roles ="Admin,Member")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [Route("api/Get2")]
        public IEnumerable<string> Get2()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPatch]
        public IHttpActionResult DoWork(int id, [FromBody]Customer cust)
        {
            Customer c = new Customer();
            c.Name = cust.Name;
            c.ID = cust.ID;
            c.LastName = cust.LastName;
            return Ok(c);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
