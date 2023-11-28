using System.ComponentModel.DataAnnotations;

namespace SantosLAITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [Display(Name = "Is Tenured")]
        public bool IsTenured { get; set; }
    }
}
