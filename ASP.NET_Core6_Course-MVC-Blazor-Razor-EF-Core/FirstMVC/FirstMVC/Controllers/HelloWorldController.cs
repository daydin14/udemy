using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Ky", Age = 6 };
            return View(doggo);
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

