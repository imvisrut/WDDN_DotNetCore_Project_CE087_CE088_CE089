using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;
using System.Collections.Generic;
using Ecommerce.Models;
using Ecommerce.Data;
using Ecommerce.Areas.Identity.Data;

namespace Ecommerce.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                TempData["message"] = "You need to login first.";
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                List<Product> cart_products = (from c in _context.Cart join p in _context.ProductTable on c.ProductId equals p.Id where c.UserId == userId select new Product() { Id = p.Id, Name = p.Name, ImageURL1 = p.ImageURL1, ImageURL2 = p.ImageURL2, MainImageURL = p.MainImageURL, Price = p.Price, Stock = p.Stock, Description = p.Description }).ToList();
                int items = cart_products.Count();
                if(items == 0)
                {
                    ViewData["isEmpty"] = true;
                }
                return View(cart_products);
            }
        }

        public IActionResult AddToCart()
        {
            int product_id = int.Parse(HttpContext.Request.Query["product_id"].ToString());
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                TempData["message"] = "You need to login first.";
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                _context.Cart.Add(new Cart() { UserId = userId, ProductId = product_id });
                _context.SaveChanges();
                TempData["message"] = "Item is successfully added to your cart.";
                return Redirect("/");
            }
        }
        public IActionResult RemoveFromCart()
        {
            int product_id = int.Parse(HttpContext.Request.Query["product_id"].ToString());
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var removeProduct = (from cart in _context.Cart where cart.UserId == userId && cart.ProductId == product_id select cart).FirstOrDefault();
            _context.Cart.Remove(removeProduct);
            _context.SaveChanges();
            TempData["message"] = "Item is successfully removed from your cart.";
            return Redirect("/Cart");
        }

        public IActionResult CheckoutCart()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Product> Order_products = (from c in _context.Cart join p in _context.ProductTable on c.ProductId equals p.Id where c.UserId == userId select new Product() { Id = p.Id, Name = p.Name, ImageURL1 = p.ImageURL1, ImageURL2 = p.ImageURL2, MainImageURL = p.MainImageURL, Price = p.Price, Stock = p.Stock, Description = p.Description }).ToList();
            EcommerceDBContext _userContext = new EcommerceDBContext();
            EcommerceAppUser user = _userContext.Users.Where(u => u.Id == userId).FirstOrDefault();
            ViewData["name"] = user.FirstName.ToString() + " " + user.LastName.ToString();
            return View(Order_products);
        }

        public IActionResult Confirm()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Cart> Order_products = (from c in _context.Cart where c.UserId == userId select new Cart() { Id = c.Id } ).ToList();
            TempData["message"] = "Your order is confirmed it will be delivered.";
            _context.Cart.RemoveRange(Order_products);
            _context.SaveChanges();
            return Redirect("/");
        }
    }
}
