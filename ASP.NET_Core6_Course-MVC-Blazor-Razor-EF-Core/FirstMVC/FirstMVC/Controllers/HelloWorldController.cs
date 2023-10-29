using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the Index page!";
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

