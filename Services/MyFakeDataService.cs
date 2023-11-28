using SantosLAITELEC.Models;

namespace SantosLAITELEC.Services
{
    public class MyFakeDataService : iMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        public MyFakeDataService()//constructor
        {
            StudentList = new List<Student>
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
            
            
            InstructorList = new List<Instructor>
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
        }
    }
}
