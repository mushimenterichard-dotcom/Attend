  namespace Domain.Entities
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public DateTime GetDateTime { get; set; }   
        public string Status { get; set; }  
        
         //Prefic should match the Navigation property name
         public int StudentId { get; set; }
         public int AttendanceId { get; set; }

              //Nagivation properties
        public Student Student{ get; set;}
        public Attendances Attendance{ get; set;}
         
    } 
}
 