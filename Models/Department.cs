using System.ComponentModel.DataAnnotations;

namespace Team_Turtle.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        // Navigation properties
        public ICollection<Student> Students { get; set; }
        public ICollection<Program> Programs { get; set; }
    }
}
