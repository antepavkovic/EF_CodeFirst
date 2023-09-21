using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Globalization;

namespace EFMigracije.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId=1, StudentName="Ante" ,DateOfBirth= DateTime.ParseExact("15.06.2015", "dd.MM.yyyy", CultureInfo.InvariantCulture), Height =180, Weight=105 },
                new Student { StudentId = 2, StudentName = "Marija", DateOfBirth = DateTime.ParseExact("17.04.2002", "dd.MM.yyyy", CultureInfo.InvariantCulture), Height = 170, Weight = 56 }

                );

            modelBuilder.Entity<Grade>().HasData(
              new Grade { GradeId =1, GradeName = "Prvi", Section = "a", StudentId = 1 },
              new Grade { GradeId = 2,GradeName = "Drugi", Section = "b", StudentId = 1 },
              new Grade { GradeId = 3, GradeName = "Treci", Section = "c", StudentId = 2 },
              new Grade { GradeId = 4, GradeName = "Cetvrti", Section = "d", StudentId = 1 },
              new Grade { GradeId =5, GradeName = "Peti", Section = "e", StudentId = 1 },
              new Grade { GradeId = 6, GradeName = "Sesti", Section = "f", StudentId = 1 },
              new Grade { GradeId = 7, GradeName = "Sedmi", Section = "g", StudentId = 2 },
              new Grade { GradeId = 8, GradeName = "Osmi", Section = "h", StudentId = 2 }
              );

        }
    }
}
