using Domain.Entities;
namespace Application.Services.AttendanceServices
{
    public interface IAttendanceService
    {
        public List<Attendances> GetAllAttendances();
    }
}