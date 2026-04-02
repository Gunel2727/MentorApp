using System.Diagnostics;
using EternaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
