using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class AttendanceRepository : IAttendance
    {
        public List<Attendances> GetAllAttendances()
        {
            return new List<Attendances>
            {

            };
        }
    }
}