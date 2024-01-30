using Creating_form_using_tag_helpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Creating_form_using_tag_helpers.Controllers
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
            return View();
        }
        //[HttpPost]
        //public string Index(Employee e)
        //{

        //    if(ModelState.IsValid)
        //    {
        //        return "NAME: " + e.Name;
        //    }
        //    else
        //    {
        //        return "validation failed"; 
        //    }
        //}
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
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
