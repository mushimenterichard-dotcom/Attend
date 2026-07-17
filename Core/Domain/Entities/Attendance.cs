  namespace Domain.Entities
{
    public class Attendances
    {
        public int Id { get; set; }
        public DateTime GetDateTime { get; set; }   

         //Prefic should match the Navigation property name
         public int StudentId { get; set; }
        public int ClassesId { get; set; }  



              //Nagivation properties
        public Student Student{ get; set;}
        public Classing Classes{ get; set;}
         
    } 
}
 