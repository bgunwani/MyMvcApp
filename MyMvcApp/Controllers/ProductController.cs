using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products =
        [
            new Product() { Id = 101, Name = "Product One" },
            new Product() { Id = 102, Name = "Product Two" },
        ];
        public IActionResult Index()
        {
            return View(products);
        }
    }
}
