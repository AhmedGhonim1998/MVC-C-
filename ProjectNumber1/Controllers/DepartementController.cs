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


        public IActionResult Add()
        {
            return View("Add");
        }

        public IActionResult SaveAdd(Departement newDeptFromRequest)
        {
            if (newDeptFromRequest.Name != null)
            {
                context.Departement.Add(newDeptFromRequest);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add" , newDeptFromRequest);
        }
    }

}
