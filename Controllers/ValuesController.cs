using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SecureAppSettingsSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration; 

        public ValuesController(IConfiguration configuration) 
        {
            _configuration = configuration; 
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(new {
                // display value of MySecretKey, which we have loaded from the 
                // vault into Configuration. 
                MySecretKey = _configuration["MySecretKey"]
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
