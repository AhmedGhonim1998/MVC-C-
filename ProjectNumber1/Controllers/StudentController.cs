using Microsoft.AspNetCore.Mvc;
using ProjectNumber1.Models;

namespace ProjectNumber1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> StudentListModel = studentBL.GetAll();
            return View("ShowAll", StudentListModel);
        }

        public IActionResult Detail(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student StudentModel = studentBL.GetById(id);
            return View("ShowDetails", StudentModel);
        }
    }
}
