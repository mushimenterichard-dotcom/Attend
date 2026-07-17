using Domain.Entities;
namespace Application.Interfaces
{
    public interface IAttendance
    {
        public List<Attendances> GetAllAttendances();

    }
}