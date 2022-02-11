using Microsoft.AspNetCore.Mvc;

namespace portfolio_i
{

    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is my index!";
        }


        // localhost:5000/hello
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects!";
        }


        [HttpGet("contact")]
        public string HelloUser(string username, string location)
        {
            return "This is my contact!";
        }
    }
}