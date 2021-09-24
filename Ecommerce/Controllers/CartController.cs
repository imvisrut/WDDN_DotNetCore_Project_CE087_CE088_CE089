﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;
using System.Collections.Generic;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Product> cart_products = ( from c in _context.Cart join p in _context.ProductTable on c.ProductId equals p.Id where c.UserId == userId select new Product() { Id = p.Id, Name = p.Name, ImageURL1 = p.ImageURL1, ImageURL2 = p.ImageURL2, MainImageURL = p.MainImageURL, Price = p.Price, Stock = p.Stock, Description = p.Description }).ToList();
            return View(cart_products);
        }

        public IActionResult AddToCart()
        {
            int product_id = int.Parse(HttpContext.Request.Query["product_id"].ToString());
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.Cart.Add(new Cart() { UserId = userId, ProductId = product_id });
            _context.SaveChanges();
            TempData["message"] = "Item is successfully added to your cart.";
            return Redirect("/");
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
    }
}