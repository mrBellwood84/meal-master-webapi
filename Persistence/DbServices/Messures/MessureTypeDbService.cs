using Domain.Messures;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Messures
{
    /// <summary>
    /// Provides database access functionality for retrieving measurement type data.
    /// </summary>
    public class MessureTypeDbService : DbServiceReadOnly<MessureType>
    {
        public MessureTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL MessureTypeSelectAll()";
        }
    }
}

