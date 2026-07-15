using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
         private readonly IClasses _classes;
        public ClassService(IClasses classess)
        {
            _classes=classess;
        }
        public List<Classing> GetAllClasses()
        {
           return _classes.GetAllClasses();
        }
    }
    
  
}