using Microsoft.AspNetCore.Mvc;
using DogApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Ky", Age = 6 };
            return View(doggo);
        }
        public IActionResult Create()
        {
            return View();
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

