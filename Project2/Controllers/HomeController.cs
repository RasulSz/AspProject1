using Microsoft.AspNetCore.Mvc;
using Project2.Entities;
using Project2.Models;
using System.Diagnostics;

namespace Project2.Controllers
{

    //drinks hotmeals fastfoods
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<AllHome> allhomee = new List<AllHome>();
            

            return View(allhomee);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink
                {
                    Id = 1,
                    Brand = "Coca-Cola",
                    Count = 10,
                },

                new Drink
                {
                    Id = 2,
                    Brand = "Fanta",
                    Count = 20,
                },

                new Drink
                {
                    Id = 3,
                    Brand = "Sprite",
                    Count = 30,
                }
            };
                return View(drinks);
        }


        public IActionResult FastFoods() 
        {
            List<FastFood> fastfoods = new List<FastFood>()
            {
                new FastFood
                {
                    Id = 1,
                    Type = "Hamburger",
                    Count = 30,
                },

                new FastFood
                {
                    Id = 2,
                    Type = "Pizza",
                    Count = 40,
                },

                new FastFood
                {
                    Id = 3,
                    Type = "Hotdog",
                    Count = 50,
                }
            };
            return View(fastfoods);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotmeals = new List<HotMeal>()
            {
                new HotMeal
                {
                    Id = 1,
                    Type = "Soup",
                    Count = 60,
                },

                new HotMeal
                {
                    Id = 2,
                    Type = "Barbeque",
                    Count = 70,
                },

                new HotMeal
                {
                    Id = 3,
                    Type = "Rice",
                    Count = 80,
                }
            };
            return View(hotmeals);
        }
    }
}