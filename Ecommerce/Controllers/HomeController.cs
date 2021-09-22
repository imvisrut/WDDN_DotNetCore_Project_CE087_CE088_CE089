using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Product Views
        public ActionResult<Product> DisplayProducts()
        {
            List<Product> products = new() {
                new Models.Product {
                        Id = 1,
                        Name = "Redragon Keyboard",
                        Description = "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)",
                        Price = 4000,
                        Stock = 200,
                        Category = "Keyboard",
                        MainImageURL = "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg",
                        ImageURL1 = "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg",
                        ImageURL2 = "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg"
                }
            };
            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
