using Hands_On_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hands_On_Models.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductId=1,Name="Mouse",Price=500,Description="Electronic Gadget"},
                new Product(){ProductId=2,Name="PS5",Price=50000,Description="Gaming console for real experience..!"}
            };
            return View(products);
        }
        public IActionResult Details()
        {
            // Initiate model with in the action Details
            Product product = new Product()
            {
                ProductId = 1,
                Name = "PS5",
                Price = 55000,
                Description = "Gaming Console for a real experience"
            };
            return View(product); // Use product details in a view page
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
