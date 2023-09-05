using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;

namespace SantosLAITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now, 
                InstructorEmail ="gabrielmontano@ust.edu.ph", Rank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorName = "Goldie May Pare", DateHired = DateTime.Parse("07/28/2022"),
                InstructorEmail ="goldiemay@ust.edu.ph", Rank = Rank.AssistProf
            },
            new Instructor()
            {
                InstructorName = "Alyssa Marie Romen", DateHired = DateTime.Parse("09/28/2022"),
                InstructorEmail ="alyssamarie@ust.edu.ph", Rank = Rank.Prof
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
    }
}
