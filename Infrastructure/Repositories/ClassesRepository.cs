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
        public void UpdateClass(UpdateClassDTO classesss)
        {
            var existingClass = _dbcontext.Classes.Find(classesss.Id);
            if (existingClass != null)
            {
                existingClass.Name = classesss.Name;
                existingClass.FacultyId = classesss.FacultyId;
                existingClass.EducationLevelId = classesss.EducationLevelId;
                _dbcontext.SaveChanges();
            }
        }
        public void DeleteClass(DeleteClassDTO classesss)
        {
           var existingClass = _dbcontext.Classes.FirstOrDefault(c => c.Id == classesss.Id);
            if(existingClass != null)
            {
                existingClass.Status = "Deleted";
                _dbcontext.SaveChanges();
            }
        }
    }
}