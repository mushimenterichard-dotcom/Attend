using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.AttendanceServices

{
    public class AttendanceService:IAttendanceService
    {
         private readonly IAttendance _attend;
        public AttendanceService(IAttendance attended)
        {
            _attend=attended;
        }
        public List<Attendances> GetAllAttendances()
        {
           return _attend.GetAllAttendances();
        }
    }
    
  
}