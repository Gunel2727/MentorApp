using EternaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var product=new Product()
            {
                Id=1,
                Name="Laptop",
                
            };
            ViewData["Message"] = "Hello from ViewData!";
            TempData["group"] = "EternaApp Team";
            ViewBag.StuName = "John Doe";
            return RedirectToAction("Test");
        }
        public IActionResult Test()
        {
             return View();
        }
    }
}
