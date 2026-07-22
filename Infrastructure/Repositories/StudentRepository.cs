
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<GetStudentDTO>> GetAllStudentsAsync()
        {
            return await _dbcontext.Students.Select(s => new GetStudentDTO
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
            ).ToListAsync();
        }
        public async Task AddStudentAsync(AddStudentDTO student)
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
            await _dbcontext.SaveChangesAsync();
        }
        public async Task <GetStudentDTO?> GetStudentByIdAsync(int id)
        {
             return await _dbcontext.Students.Where(s => s.Id == id).Select(s => new GetStudentDTO
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
             }).FirstOrDefaultAsync();
        }
        public async Task UpdateStudentAsync(UpdateStudentDTO student)
        {
            var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(rr => rr.Id == student.Id);
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

               await _dbcontext.SaveChangesAsync();
            }


        }
        public async Task DeleteStudentAsync(DeleteStudentDTO student)
        {
            var ExistingStudent = await _dbcontext.Students.FirstOrDefaultAsync(rr => rr.Id == student.Id);
            if(ExistingStudent != null)
            {
                ExistingStudent.Status = "Deleted";
               await _dbcontext.SaveChangesAsync();
            }
        }
    }
}