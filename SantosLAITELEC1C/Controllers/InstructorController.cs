using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;

namespace SantosLAITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    InstructorId = 1,InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano", 
                    Rank = Rank.Instructor, 
                    HiringDate = DateTime.Parse("2022-08-26"), 
                    IsTenured = true
                },
                new Instructor()
                {
                    InstructorId = 2, 
                    InstructorFirstName = "Robert", 
                    InstructorLastName = "Santos", 
                    Rank = Rank.AssistantProfessor, 
                    HiringDate = DateTime.Parse("2022-08-07"), 
                    IsTenured = true
                },
                new Instructor()
                {
                    InstructorId = 2, InstructorFirstName = "Jeanny", 
                    InstructorLastName = "Garcia", 
                    Rank = Rank.Instructor, HiringDate = 
                    DateTime.Parse("2022-09-07"), 
                    IsTenured = true
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
    }
}
