using System.Data;
using DataAccess.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DbAccess;

public class DataAccessHelper : IDataAccessHelper
{
    private readonly IConfiguration _config;

    public DataAccessHelper(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<Person>> GetPeopleAsync()
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_config.GetConnectionString("myDb1")))
        {
            var output = await connection.QueryAsync<Person>("select * from PeopleTable");

            return output;
        }
    }
}
