using JokeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApplication.Controllers
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<Product> products()
        {
            var products = new List<Product>
            {
                new Product{
                    id = "1",
                    name = "Tea",
                    price = "99.99",
                    quantity = "5"

                }
            };

             return products;
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:44301/home/privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // https://localhost:44301/home/error

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
