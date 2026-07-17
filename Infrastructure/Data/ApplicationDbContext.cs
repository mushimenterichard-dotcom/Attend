using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
     public class ApplicationDbContext : DbContext
     {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Student> Students{get;set;}
        public DbSet<Classing> Classes{get;set;}
        public DbSet<Attendances> Attendance{get;set;}
        public DbSet<ClassStudent> ClassStudents{get;set;}
        public DbSet<EducationLevel> EducationLevels{get;set;}
        public DbSet<Faculty> Faculties{get;set;}
        public DbSet<StudentAttendance> StudentAttendance{get;set;}






     }
}