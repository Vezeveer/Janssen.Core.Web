using Janssen.Core.Web.Models;
using Janssen.Core.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Janssen.Core.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: Student
        public ActionResult Index()
        {
            return View(studentService.Get());
        }

        // GET: Student/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = studentService.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            try
            {
                // creation logic here
                if (ModelState.IsValid)
                {
                    studentService.Create(student);
                    return RedirectToAction(nameof(Index));
                }
                return View(student);
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = studentService.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Student student)
        {
            try
            {
                // update logic here
                if (id != student.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    studentService.Update(id, student);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(student);
                }
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = studentService.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var student = studentService.Get(id);

                if (student == null)
                {
                    return NotFound();
                }

                studentService.Remove(student.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}