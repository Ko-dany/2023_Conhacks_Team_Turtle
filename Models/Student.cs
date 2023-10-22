using System.ComponentModel.DataAnnotations;
using Team_Turtle.Models.Validation;

namespace Team_Turtle.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "The email value is required")]
        [EmailValidationAttribute]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please set your password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "The name value is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please select your department")]
        public int? DepartmentId { get; set; }

        [Required(ErrorMessage = "Please select your program")]
        public int? ProgramId { get; set; }

        [Required(ErrorMessage = "Please select your level")]
        public int? Level { get; set; }

        // Navigation properties
        public Department? Department { get; set; }
        public Program? Program { get; set; }
    }
}
