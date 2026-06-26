using Microsoft.AspNetCore.Mvc;
using MVCWebAppTest.Models;

namespace MVCWebAppTest.Controllers
{
    public class StudentController1 : Controller
    {

        private static List<Student> students = new List<Student>();

        static StudentController1() {
            students.Add(new Student { Id = 101, Name = "Krushna", Fees = 12234.78f, Age = 26});
        }
        public IActionResult Index()
        {
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student s = new Student();
            foreach (var item in students) {
                if (item.Id == id) {
                    return View(item);
                }
            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult Edit(Student student)
        {
            foreach (var item in students)
            {
                if (item.Id == student.Id)
                {
                    item.Name = student.Name;
                    item.Fees = student.Fees;
                    item.Age = student.Age;
                    break;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id) {
            foreach (var student in students) {
                if (student.Id == id) {
                    return View(student);
                }
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int id) {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return View(student);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    students.Remove(student);
                    break;
                }
            }
            return RedirectToAction("Index");
        }























        public IActionResult Message()
        {
            return Content("Hello Am message");
        }
        public IActionResult GetJSON()
        {
            var result = new { id = 12 ,Name= "Krushna"};
            return Json(result);
        }

        public IActionResult GotoIndex() {
            return RedirectToAction("Index");
            //return StatusCode(500);
        }

    }
}
