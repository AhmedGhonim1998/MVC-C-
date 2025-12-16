using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectNumber1.Models;
using ProjectNumber1.ViewModel;

namespace ProjectNumber1.Controllers
{
    public class EmployeeController : Controller
    {
        
        ProContext context = new ProContext(); 
        
        public IActionResult Details(int id)
        {
            //this is additionat data not found in the model i want to send it to view
            string msg = "Hello from action";
            int temp = 50;
            List<string> branches = new List<string>();
            branches.Add("Cairo");
            branches.Add("Alex");
            branches.Add("Clifornia");
            ViewData["Msg"] = msg;
            ViewData["Temp"] = temp;
            ViewData["brch"]=branches;
            ViewBag.Color = "Red";
            ViewData["Color"] = "Blue";

            Employee empModel = context.Employee.FirstOrDefault(e => e.Id == id);
            return View("Details" , empModel);
        }

        public IActionResult DetailsVM(int id)
        {
            Employee empModel = context.Employee.Include(e=>e.Departement)
                .FirstOrDefault(e => e.Id == id);
            List<string> branches = new List<string>();
            branches.Add("Cairo");
            branches.Add("Alex");
            branches.Add("Clifornia");
            //declare view model
            EmpDeptColorTempMsgBrchViewModel EmpVm = new EmpDeptColorTempMsgBrchViewModel();
            //Mapping
            EmpVm.EmpName = empModel.Name;
            EmpVm.DeptName = empModel.Departement.Name;
            EmpVm.Color = "red";
            EmpVm.temp = 30;
            EmpVm.Msg = "Hello from here";
            EmpVm.Branches = branches;
            return View("DetailsVM", EmpVm);

        }
    }
}
