using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.ClassStudentServices

{
    public class ClassStudentService:IClassStudentService
    {
         private readonly IClassStudent _classstudent;
        public ClassStudentService(IClassStudent classstudent)
        {
            _classstudent=classstudent;
        }
        public List<ClassStudent> GetAllClassStudent()

        {
           return _classstudent.GetAllClassStudent();
        }
    }
    
  
}