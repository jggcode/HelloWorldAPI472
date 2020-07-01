using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorld.API.DotNetFramework472.Controllers
{
    public class ValuesController : ApiController
    {
        public DateTime DateTime { get; set; }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            if (DateTime == DateTime.MinValue)
            {
                DateTime = DateTime.Now;
            }

            var greeting = new Greeting(DateTime);

            return greeting.GetGreeting() + " The current date and time is: " + DateTime;
        }
    }
}
