using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC.Models;
using SantosLAITELEC.Services;

namespace SantosLAITELEC1C.Controllers
{
    public class InstructorController : Controller
    {

        private readonly iMyFakeDataService _dummyData;

        public InstructorController(iMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }


        public IActionResult Index()
        {

            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dummyData.InstructorList.Add(newInstructor);
            return View("Index", _dummyData.InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.InstructorId == instructorChanges.InstructorId);
            if (instructor != null)
            {
                instructor.InstructorId = instructorChanges.InstructorId;
                instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
                instructor.InstructorLastName = instructorChanges.InstructorLastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
            }

            return View("Index", _dummyData.InstructorList);
        }
    }
}
