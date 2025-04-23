﻿using Dapper;
using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbService.Messures
{
    public class MessureDbService : DbConnection
    {
        public MessureDbService(IConfiguration config) : base(config) { }

        public async Task<List<Messure>> GetAll()
        {
            using var conn = CreateConnection();

            var sql = "CALL MessureSelectAll ()";
            //var sql = "SELECT m.id, fullname, shortname, relativesize, m.messuretypeid, mt.id, type FROM messure AS m JOIN messuretype AS mt ON m.messuretypeid = mt.id";
            var result = await conn.QueryAsync<Messure, MessureType, Messure>(sql, (m, mt) =>
            {
                m.Type = mt;
                return m;
            }, splitOn: "MessureTypeId");

            return result.ToList();
        }
    }
}
