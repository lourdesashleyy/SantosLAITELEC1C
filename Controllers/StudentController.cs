using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC.Models;
using SantosLAITELEC.Services;

namespace SantosLAITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly iMyFakeDataService _dummyData;

        public StudentController(iMyFakeDataService dummyData) { 
            _dummyData = dummyData;
        }


        public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }

        public IActionResult UpdateStudent()
        {

            return View();
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }


        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);

            if (student != null)
            {
                student.StudentFirstName = studentChanges.StudentFirstName;
                student.StudentLastName = studentChanges.StudentLastName;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;
            }

            return RedirectToAction("Index");
        }
    }
}
