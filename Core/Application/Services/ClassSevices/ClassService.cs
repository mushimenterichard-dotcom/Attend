using Domain.Entities;
namespace Application.Services.ClassServices

{
    public class ClassService:IClassService
    {
        public List<Classing> GetAllClasses()
        {
            return new List<Classing>
            {
                 new Classing  { IdClass = 1 , ClassName = "College-level (AP / IB)" , InstructorName = "MELLISA uwase" , ClassCode = 001},
                 new Classing  { IdClass = 2 , ClassName = "Honors / Advanced" , InstructorName = "BIKORIMANA Louis" , ClassCode = 002}

            };
        }
    }
  
}