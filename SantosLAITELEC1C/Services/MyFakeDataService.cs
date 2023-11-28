using System;
using SantosLAITELEC1C.Models;
using SantosLAITELEC1C.Services;

namespace SantosLAITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        //Constructor
        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIS, BirthDate = DateTime.Parse("2022-08-26")
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, BirthDate = DateTime.Parse("2022-08-07")
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSIS, BirthDate = DateTime.Parse("2020-01-25")
                }
            };
            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = false
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = false
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Parse("2020-01-25"), IsTenured = true
                }
            };
        }
        
    }
}
