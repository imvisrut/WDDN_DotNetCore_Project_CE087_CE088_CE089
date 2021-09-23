using System.Collections.Generic;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new ApplicationDbContext();
            return View(db.ProductTable.ToList());
        }
    }
}
