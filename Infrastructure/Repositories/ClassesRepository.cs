using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class ClassesRepository : IClasses
    {
        private readonly ApplicationDbContext _dbcontext;
        public ClassesRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public List<Classing> GetAllClasses()
        {
            return _dbcontext.Classes.ToList();
        }
        public void AddClass(Classing classesss)
        {
            _dbcontext.Classes.Add(classesss);
            _dbcontext.SaveChanges();
        }
    }
}