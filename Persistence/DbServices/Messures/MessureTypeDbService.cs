using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Messures
{
    public class MessureTypeDbService : DbServiceReadOnly<MessureType>
    {
        public MessureTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MessureTypeSelectAll()";
        }
    }
}

