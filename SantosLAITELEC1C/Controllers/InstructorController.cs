using Microsoft.AspNetCore.Mvc;
using SantosLAITELEC1C.Models;
using SantosLAITELEC1C.Services;


namespace SantosLAITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }
        public IActionResult Index()
        {

            return View(_fakeData.InstructorList);
        }
        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Instructor deleteInstructor)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == deleteInstructor.Id);

            if (instructor != null)//was a student found?
            {
                _fakeData.InstructorList.Remove(instructor);
                return RedirectToAction("Index");
            }

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
            if(!ModelState.IsValid) //if Data is invalid
                return View();
                
            _fakeData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
       
        [HttpPost]
        public IActionResult Edit(Instructor editInstructor)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(st => st.Id == editInstructor.Id);
            if(instructor != null)
            {
                instructor.Id = editInstructor.Id;
                instructor.FirstName = editInstructor.FirstName;
                instructor.LastName = editInstructor.LastName;
                instructor.Rank = editInstructor.Rank;
                instructor.HiringDate = editInstructor.HiringDate;
                instructor.IsTenured = editInstructor.IsTenured;
            }
            return RedirectToAction("Index");
        }
    }
}