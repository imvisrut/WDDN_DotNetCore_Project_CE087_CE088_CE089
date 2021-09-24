using System.Diagnostics;
using System.Linq;
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
        public IActionResult Index()
        {
            string query_string = HttpContext.Request.Query["search"].ToString();
            var _context = new ApplicationDbContext();

            if(query_string == null)
            {
                var products = _context.ProductTable.ToList();
                return View(products);
            }
            else
            {
                var search_products = _context.ProductTable.Where(p => p.Name.Contains(query_string)).ToList();
                return View(search_products);
            }
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
