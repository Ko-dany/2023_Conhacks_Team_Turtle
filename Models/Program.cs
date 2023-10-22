using System.ComponentModel.DataAnnotations;

namespace Team_Turtle.Models
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public string? ProgramName { get; set; }
        public int? DepartmentId { get; set; }
        public int? Length { get; set; }

        // Navigation properties
        public Department? Department { get; set; }
        public ProgramLength? ProgramLength { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
