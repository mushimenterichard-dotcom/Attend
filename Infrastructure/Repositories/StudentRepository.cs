using Application.DTOs;
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

        public List<GetStudentDTO> GetAllStudents()
        {
            return _dbcontext.Students.Select(s => new GetStudentDTO
            {
                Id = s.Id,
                Name = s.Name,
                Sex = s.Sex,
                DateOfBirth = s.DateOfBirth,
                Reg_Number = s.Reg_Number,
                Address = s.Address,
                Parent_Name = s.Parent_Name,
                Parent_Phone = s.Parent_Phone,
                Phone = s.Phone,
                Email = s.Email,
                Status = s.Status,
                UserAdded = s.UserAdded,
                DateAdded = s.DateAdded
            }
            ).ToList();
        }
        public void AddStudent(AddStudentDTO student)
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
        public GetStudentDTO? GetStudentById(int id)
        {
             return _dbcontext.Students.Where(s => s.Id == id).Select(s => new GetStudentDTO
             {
                 Id = s.Id,
                 Name = s.Name,
                 Sex = s.Sex,
                 DateOfBirth = s.DateOfBirth,
                 Reg_Number = s.Reg_Number,
                 Address = s.Address,
                 Parent_Name = s.Parent_Name,
                 Parent_Phone = s.Parent_Phone,
                 Phone = s.Phone,
                 Email = s.Email,
                 Status = s.Status,
                 UserAdded = s.UserAdded,
                 DateAdded = s.DateAdded
             }).FirstOrDefault();
        }
        public void UpdateStudent(UpdateStudentDTO student)
        {
            var ExistingStudent = _dbcontext.Students.FirstOrDefault(rr => rr.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Name = student.Name;
                ExistingStudent.Sex = student.Sex;
                ExistingStudent.Address = student.Address;
                ExistingStudent.Email = student.Email;
                ExistingStudent.Parent_Phone = student.Parent_Phone;
                ExistingStudent.Parent_Name = student.Parent_Name;
                ExistingStudent.Phone = student.Phone;
                ExistingStudent.DateOfBirth = student.DateOfBirth;
                ExistingStudent.Reg_Number = student.Reg_Number;

                _dbcontext.SaveChanges();
            }


        }
        public void DeleteStudent(DeleteStudentDTO student)
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