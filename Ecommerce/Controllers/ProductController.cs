using System.Collections.Generic;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data;
using System.Linq;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View(db.ProductTable.ToList());
        }

        [Route("Product/ProductDetail/{product_id}")]
        public IActionResult ProductDetail(int product_id)
        {
            Product product = db.ProductTable.Where(p => p.Id == product_id).FirstOrDefault<Product>();
            return View(product);
        }
    }
}
