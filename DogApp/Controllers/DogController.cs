using Microsoft.AspNetCore.Mvc;
using DogApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogApp.Controllers
{
    public class DogController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }
        public IActionResult Create()
        {
            DogViewModel newDog = new DogViewModel();
            return View(newDog);
        }

        public IActionResult CreateDog(DogViewModel dog)
        {
            dogs.Add(dog);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}

