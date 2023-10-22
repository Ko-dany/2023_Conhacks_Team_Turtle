using System.ComponentModel.DataAnnotations;

namespace Team_Turtle.Models
{
    public class ProgramLength
    {
        [Key]
        public int Length { get; set; }

        // Navigation properties
        public ICollection<Program> Programs { get; set; }
    }
}
