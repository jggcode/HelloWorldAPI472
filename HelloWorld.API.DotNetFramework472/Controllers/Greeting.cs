using System;

namespace HelloWorld.API.DotNetFramework472.Controllers
{
    public class Greeting
    {
        private DateTime greetingDateTime;

        public Greeting(DateTime greetingDateTime)
        {
            this.greetingDateTime = greetingDateTime;
        }

        public string GetGreeting()
        {
            if (greetingDateTime == null)
            {
                return "Hello from .Net Framework 4.7.2!";
            }

            if (greetingDateTime.Hour < 12)
            {
                return "Good morning from .Net Framework 4.7.2!";
            }

            if (greetingDateTime.Hour < 18)
            {
                return "Good afternoon from .Net Framework 4.7.2!";
            }

            return "Good evening from .Net Framework 4.7.2!";
        }
    }
}