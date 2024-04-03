using Microsoft.AspNetCore.Mvc;
using PartialViewRazor.Models;
using System.Diagnostics;

namespace PartialViewRazor.Controllers
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
            // Datos de productos
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Producto 1", Description = "Descripción del producto 1", Price = 10.99m },
                new Product { Id = 2, Name = "Producto 2", Description = "Descripción del producto 2", Price = 19.99m },
                new Product { Id = 3, Name = "Producto 3", Description = "Descripción del producto 3", Price = 25.49m },
                new Product { Id = 4, Name = "Producto 4", Description = "Descripción del producto 4", Price = 15.99m },
                new Product { Id = 5, Name = "Producto 5", Description = "Descripción del producto 5", Price = 35.49m }
            };

            return View(products);
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