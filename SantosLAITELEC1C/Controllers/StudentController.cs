using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;

namespace SantosLAITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    StudentId= 1,
                    StudentFirstName = "Lourdes Ashley",
                    StudentLastName = "Santos", 
                    Course = Course.BSIT, 
                    AdmissionDate = DateTime.Parse("2021-08-26"), 
                    GPA = 1.5, 
                    Email = "lourdesashleysantos@gmail.com"
                },
                new Student()
                {
                    StudentId= 2,StudentFirstName = "Alyssa Marie",
                    StudentLastName = "Romen", 
                    Course = Course.BSIS, 
                    AdmissionDate = DateTime.Parse("2021-08-07"), 
                    GPA = 1, 
                    Email = "alyssaromen@gmail.com"
                },
                new Student()
                {
                    StudentId= 3,
                    StudentFirstName = "Luis Enrico",
                    StudentLastName = "Granada", 
                    Course = Course.BSCS, 
                    AdmissionDate = DateTime.Parse("2021-01-25"), 
                    GPA = 1.5, 
                    Email = "luisgranada@gmail.com"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
    }
}
