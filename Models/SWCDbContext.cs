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
        public DbSet<Program> Programs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Email = "jseo9123@conestogac.on.ca", Password="12345678", Name = "Juhwan Seo", ProgramId = 2, Level = 3}
            );


            modelBuilder.Entity<Program>().HasData(
                new Program()
                {
                    ProgramId = 1,
                    ProgramName = "Computer Programming",
                    Length = 2
                },
                new Program()
                {
                    ProgramId = 2,
                    ProgramName = "Computer Programming and Analysis",
                    Length = 3
                }
            );
        }
    }
}
