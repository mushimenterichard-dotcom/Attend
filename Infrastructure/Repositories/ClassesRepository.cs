using Application.Interfaces;
using Application.DTOs;
using Infrastructure.Data;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class ClassesRepository : IClasses
    {
        private readonly ApplicationDbContext _dbcontext;
        public ClassesRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public List<GetClassDTO> GetAllClasses()
        {
          return _dbcontext.Classes.Select(c => new GetClassDTO
            {
                Id = c.Id,
                Name = c.Name,
                FacultyId = c.FacultyId,
                EducationLevelId = c.EducationLevelId,
                Status = c.Status,
                UserAdded = c.UserAdded,
                DateAdded = c.DateAdded, 

            }).ToList();
        }
        public void AddClass(AddClassDTO classesss)
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
            _dbcontext.SaveChanges();
        }
        public GetClassDTO? GetClassById(int id)
        {
             return _dbcontext.Classes.Where(c => c.Id == id).Select(c => new GetClassDTO
             {
                 Id = c.Id,
                 Name = c.Name,
                 FacultyId = c.FacultyId,
                 EducationLevelId = c.EducationLevelId,
                 Status = c.Status,
                 UserAdded = c.UserAdded,
                 DateAdded = c.DateAdded
             }).FirstOrDefault();
        }
    }
}