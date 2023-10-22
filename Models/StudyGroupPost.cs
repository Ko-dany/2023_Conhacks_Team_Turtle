using System.ComponentModel.DataAnnotations;

namespace Team_Turtle.Models
{
    public class StudyGroupPost
    {
        [Key]
        public int PostId { get; set; }

        public int CreaterId { get; set; }
        public Student? Student { get; set; } 

        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PostedDate { get; set; }
        public List<string>? Members { get; set; }
        public string? ZoomLink { get; set; }
        public string? DiscordLink { get; set; }

    }
}
