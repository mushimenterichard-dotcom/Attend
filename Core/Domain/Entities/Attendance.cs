  namespace Domain.Entities
{
    public class Attendances
    {
         public int Id { get; set; }
         public string InstructorName { get; set; }  

         //Prefic should match the Navigation property name
        public int ClassingId { get; set; }  

              //Nagivation properties
        public Classing Classing{ get; set;}

        public ICollection<Student> Student { get;set; }
         
    } 
}
 