  namespace Domain.Entities
{
    public class ClassStudent
    {
        public int Id { get; set; }

         //Prefic should match the Navigation property name
        public int ClassesId { get; set; }
        public int StudentId { get; set; }


          //Nagivation properties
        public Classing Classes{ get; set;}
        public Student Student{ get; set;}
       
    } 
}
 