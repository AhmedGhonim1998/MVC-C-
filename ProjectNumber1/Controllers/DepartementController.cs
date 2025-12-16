using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectNumber1.Models;


namespace ProjectNumber1.Controllers
{
    public class DepartementController : Controller
    {
        ProContext context = new ProContext();
        public IActionResult Index()
        {
            List<Departement> departementList = context.Departement.Include(d=>d.Emps)
                .ToList();
            return View("index" , departementList);
        }
    }
}
