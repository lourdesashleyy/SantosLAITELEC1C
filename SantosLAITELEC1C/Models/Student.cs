using System.ComponentModel.DataAnnotations;

namespace SantosLAITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSIS, BSCS
    }
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "First Name")]

        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]

        public string? LastName { get; set; }
        [Display(Name = "Course")]

        public Course Course { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]

        public DateTime BirthDate { get; set; }

    }
}
