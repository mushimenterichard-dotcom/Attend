using Application.Interfaces;
using Application.DTOs;
using Infrastructure.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ClassesRepository : IClasses
    {
        private readonly ApplicationDbContext _dbcontext;
        public ClassesRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public async Task <List<GetClassDTO>> GetAllClassesAsync()
        {
          return await _dbcontext.Classes.Select(c => new GetClassDTO
            {
                Id = c.Id,
                Name = c.Name,
                FacultyId = c.FacultyId,
                EducationLevelId = c.EducationLevelId,
                Status = c.Status,
                UserAdded = c.UserAdded,
                DateAdded = c.DateAdded, 

            }).ToListAsync();
        }
        public async Task AddClassAsync(AddClassDTO classesss)
        {
            _dbcontext.Classes.Add(new Classing
            {
                Name = classesss.Name,
                FacultyId = classesss.FacultyId,
                EducationLevelId = classesss.EducationLevelId,
                UserAdded = "Admin",
                DateAdded = DateTime.UtcNow,
                Status = "Active"
            });
            await _dbcontext.SaveChangesAsync();
        }
        public async Task <GetClassDTO?> GetClassByIdAsync(int id)
        {
             return await _dbcontext.Classes.Where(c => c.Id == id).Select(c => new GetClassDTO
             {
                 Id = c.Id,
                 Name = c.Name,
                 FacultyId = c.FacultyId,
                 EducationLevelId = c.EducationLevelId,
                 Status = c.Status,
                 UserAdded = c.UserAdded,
                 DateAdded = c.DateAdded
             }).FirstOrDefaultAsync();
        }
        public async Task UpdateClassAsync(UpdateClassDTO classesss)
        {
            var existingClass = await _dbcontext.Classes.FirstOrDefaultAsync(cc => cc.Id == classesss.Id);
            if (existingClass != null)
            {
                existingClass.Name = classesss.Name;
                existingClass.FacultyId = classesss.FacultyId;
                existingClass.EducationLevelId = classesss.EducationLevelId;
               await _dbcontext.SaveChangesAsync();
            }
        }
        public async Task DeleteClassAsync(DeleteClassDTO classesss)
        {
           var existingClass =await  _dbcontext.Classes.FirstOrDefaultAsync(c => c.Id == classesss.Id);
            if(existingClass != null)
            {
                existingClass.Status = "Deleted";
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}