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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Email = "jseo9123@conestogac.on.ca", Name = "Juhwan Seo", DepartmentId = 1, ProgramId = 2, Level = 3}
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
        }
    }
}
