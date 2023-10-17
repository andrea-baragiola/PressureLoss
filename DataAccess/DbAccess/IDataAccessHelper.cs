using DataAccess.Models;

namespace DataAccess.DbAccess
{
    public interface IDataAccessHelper
    {
        Task<IEnumerable<Person>> GetPeopleAsync();
    }
}