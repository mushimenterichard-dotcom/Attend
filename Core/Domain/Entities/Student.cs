  namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }   
        public string Reg_Number { get; set; }   
        public string Address { get; set; }   
        public string Parent_Name { get; set; }   
        public string Parent_Phone { get; set; }   
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public ICollection<ClassStudent> ClassStudent { get;set; }

        public ICollection<Attendances> Attendance { get;set; }


    } 
}
 