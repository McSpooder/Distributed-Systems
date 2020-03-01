using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DannysWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        // GET: api/Translation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Translation/5
        [HttpGet("{id:int}", Name = "GetInt")]
        public string Get(int id)
        {
            string result = string.Format("Your value plus 100 is: {0}", (100 + id).ToString());
            return result;
        }

        // GET: api/Translation/value
        [HttpGet("{inStr}", Name = "GetString")]
        public string Get(string inStr)
        {
            return "You have sent in: " + inStr;
        }

        // POST: api/Translation
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Translation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
