using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
      private readonly ApplicationDbContext _dbcontext;
        public StudentRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public List<Student> GetAllStudents()
        {
            return _dbcontext.Students.ToList();
        }
        public void AddStudent(Student student)
        {
            _dbcontext.Students.Add(new Student
            {
                Name = student.Name,
                Sex = student.Sex,
                DateOfBirth = student.DateOfBirth,
                Reg_Number = student.Reg_Number,
                Address = student.Address,
                Parent_Name = student.Parent_Name,
                Parent_Phone = student.Parent_Phone,
                Phone = student.Phone,
                Email = student.Email,
                UserAdded = "Admin",
                DateAdded = DateTime.UtcNow,
                Status = "Active"
            });
            _dbcontext.SaveChanges();
        }
        public Student? GetStudentById(int id)
        {
             return _dbcontext.Students.FirstOrDefault(rr => rr.Id == id);
        }
        public void UpdateStudent(Student student)
        {
            var ExistingStudent = _dbcontext.Students.FirstOrDefault(rr => rr.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.Address = student.Address;
                ExistingStudent.Email = student.Email;
                ExistingStudent.Parent_Phone = student.Parent_Phone;

                _dbcontext.SaveChanges();
            }



        }
        public void DeleteStudent(Student student)
        {
            var ExistingStudent = _dbcontext.Students.FirstOrDefault(rr => rr.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Status = "Deleted";
                _dbcontext.SaveChanges();
            }
        }
    }
}