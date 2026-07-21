 using System.ComponentModel.DataAnnotations;
 
  namespace Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        
         [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Sex is required")]
        public string Sex { get; set; }
        
         [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }   
        
         [Required(ErrorMessage = "Reg_Number is required")]
        public string Reg_Number { get; set; }   
        
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }   
        
        [Required(ErrorMessage = "Parent_Name is required")]
        public string Parent_Name { get; set; }   
        
        [Required(ErrorMessage = "Parent_Phone is required")]
        public string Parent_Phone { get; set; }   
        
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; } = "Active";

        [Required(ErrorMessage = "UserAdded is required")]
        public string UserAdded { get; set; }

        [Required(ErrorMessage = "DateAdded is required")]
        public DateTime DateAdded { get; set; } = DateTime.UtcNow; 
    } 
}
 