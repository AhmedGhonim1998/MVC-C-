using Microsoft.AspNetCore.Mvc;

namespace ProjectNumber1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
