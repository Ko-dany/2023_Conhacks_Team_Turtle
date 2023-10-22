using Microsoft.EntityFrameworkCore;

namespace Team_Turtle.Models
{
    public class SWCDbContext : DbContext
    {
        public SWCDbContext(DbContextOptions<SWCDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramLength> ProgramLengths { get; set; }

        public DbSet<StudyGroupPost> studyGroupPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { 
                    StudentId = 1, 
                    Email = "jseo9123@conestogac.on.ca", 
                    Name = "Juhwan Seo", 
                    DepartmentId = 1, 
                    ProgramId = 2, 
                    Level = 3
                }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    DepartmentId = 1,
                    DepartmentName = "School of Applied Computer Science and Information Technology",
                }
            );

            modelBuilder.Entity<Program>().HasData(
                new Program()
                {
                    ProgramId = 1,
                    ProgramName = "Computer Programming",
                    DepartmentId = 1,
                    Length = 2
                },
                new Program()
                {
                    ProgramId = 2,
                    ProgramName = "Computer Programming and Analysis",
                    DepartmentId = 1,
                    Length = 3
                }
            );

            modelBuilder.Entity<ProgramLength>().HasData(
                new ProgramLength()
                {
                    Length = 1
                },
                new ProgramLength()
                {
                    Length = 2
                },
                new ProgramLength()
                {
                    Length = 3
                }
            );

            modelBuilder.Entity<StudyGroupPost>().HasData(
                new StudyGroupPost()
                {
                    PostId = 1,
                    CreaterId = 1,
                    Title = "Anyone interested in React.js?",
                    Description = "We're looking for students who want to study React.js together.",
                    PostedDate = DateTime.Now.AddDays(-3),
                    Members = new List<string> { "Dany", "Kyle" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 2,
                    CreaterId = 1,
                    Title = "Python for Beginners",
                    Description = "This is a Python study group for beginners.",
                    PostedDate = DateTime.Now.AddDays(-3),
                    Members = new List<string> { "John", "Alice" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 3,
                    CreaterId = 2,
                    Title = "Java Enthusiasts",
                    Description = "Join us to explore the world of Java programming.",
                    PostedDate = DateTime.Now.AddDays(-5),
                    Members = new List<string> { "Emily", "Charlie", "Grace" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 4,
                    CreaterId = 3,
                    Title = "C# Developers Unite",
                    Description = "A study group for C# developers of all levels.",
                    PostedDate = DateTime.Now.AddDays(-7),
                    Members = new List<string> { "Michael"},
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 5,
                    CreaterId = 4,
                    Title = "Exploring JavaScript",
                    Description = "Join our JavaScript study group for in-depth discussions.",
                    PostedDate = DateTime.Now.AddDays(-10),
                    Members = new List<string> { "Michael", "Sophia", "Oliver", "Ava" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 6,
                    CreaterId = 5,
                    Title = "Data Science Enthusiasts",
                    Description = "A study group for data science and machine learning enthusiasts.",
                    PostedDate = DateTime.Now.AddDays(-15),
                    Members = new List<string> { "Liam", "Mia", "Henry" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                },
                new StudyGroupPost()
                {
                    PostId = 7,
                    CreaterId = 6,
                    Title = "Web Development Journey",
                    Description = "Join us to learn about web development technologies and frameworks.",
                    PostedDate = DateTime.Now.AddDays(-20),
                    Members = new List<string> { "Aiden", "Mia" },
                    ZoomLink = "https://zoom.us/",
                    DiscordLink = "https://discord.gg/c7qxJVDm"
                }
            );
        }
    }
}
