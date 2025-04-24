﻿using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Messures
{
    public class MessureTypeDbService : DbConnection, IDbSubService<MessureType>
    {
        public MessureTypeDbService(IConfiguration config) : base(config) { }

        public async Task<List<MessureType>> GetAllAsync()
        {
            using var conn = CreateConnection();

            var query = "CALL MessureTypeSelectAll()";
            var result = (await conn.QueryAsync<MessureType>(query)).ToList();

            return result;
        }
    }
}
