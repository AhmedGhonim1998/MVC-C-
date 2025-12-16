using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectNumber1.Models;

namespace ProjectNumber1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public ContentResult ShowMsg()
        {
            //deaclare
            ContentResult result = new ContentResult();
            //initail
            result.Content = "Hi my name is ahmed";
            //return
            return result;
        }

        public ViewResult ShowView()
        {
            //logic
            ViewResult result = new ViewResult();
            //declare
            //initial
            result.ViewName = "View1";
            //return
            return result;
        }

        public IActionResult ShowMix(int id)
        {
            if (id%2==0)
            {
                return View("View1");
            }
            else
            {
                
                return Content("Hello world");
            }
        }

        public ViewResult view(string viewName)
        {
            //logic
            ViewResult result = new ViewResult();
            //declare
            //initial
            result.ViewName = viewName;
            //return
            return result;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
