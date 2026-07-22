using System.Security.Cryptography.X509Certificates;
namespace Domain.Entities
{
public class Classing
    {
        public int Id{ get;set; }
        public string Name{ get;set; }
        public string Status{ get;set; } = "Active";
        public string UserAdded{ get;set; }
        public DateTime DateAdded{ get;set; } = DateTime.UtcNow;
        
        //Prefic should match the Navigation property name
         public int FacultyId{ get;set; }
        public int EducationLevelId{ get;set; }

         //Nagivation properties
        public Faculty Faculty{ get; set;}
        public EducationLevel EducationLevel{ get; set;}
       
    }
}