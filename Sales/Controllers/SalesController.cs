using Microsoft.AspNetCore.Mvc;
using Sales.Models;

namespace Sales.Controllers;

public class SalesController : Controller
{
    public IActionResult Index()
    {
        List<Product> list = new List<Product>()
        {
            new Product { Name = "Product 1", Price = 100, Quantity = 10 },
            new Product { Name = "Product 2", Price = 200, Quantity = 20 },
            new Product { Name = "Product 3", Price = 300, Quantity = 30 }
        };
        return View(list);
    }

    
}
