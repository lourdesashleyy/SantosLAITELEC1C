using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;

namespace SantosLAITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Lourdes Ashley Santos";
            st.DateEnrolled = DateTime.Parse("8/30/2023");
            st.Course = Course.BSIT;
            st.Email = "lourdesashley.santos.cics@ust.edu.ph";

            ViewBag.Student = st;

            return View();
        }
    }
}
