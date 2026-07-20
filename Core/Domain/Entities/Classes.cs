using System.Security.Cryptography.X509Certificates;
namespace Domain.Entities
{
public class Classing
    {
        public int Id{ get;set; }
        public string Name{ get;set; }

        //Prefic should match the Navigation property name
         public int FacultyId{ get;set; }
        public int EducationLevelId{ get;set; }

         //Nagivation properties
        public Faculty Faculty{ get; set;}
        public EducationLevel EducationLevel{ get; set;}
       
    }
}