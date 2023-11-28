
using SantosLAITELEC.Models;

namespace SantosLAITELEC.Services
{
    public interface iMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
