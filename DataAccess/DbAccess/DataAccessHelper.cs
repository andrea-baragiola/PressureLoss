using System.Data;
using DataAccess.Models;
using Dapper;

namespace DataAccess.DbAccess
{
    public class DataAccessHelper
    {
        private readonly string connectionString = "Server=.;Database=People;User Id=sa;Password=Password1@;";
        public async Task<IEnumerable<Person>> GetPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var output = await connection.QueryAsync<Person>("select * from PeopleTable");

                return output;
            }
        }
    }
}
