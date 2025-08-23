using Domain.Misc;
using Microsoft.Extensions.Configuration;

namespace Persistence.DbServices.Misc
{
    /// <summary>
    /// Provides read-only database access for <see cref="SourceType"/> entities.
    /// </summary>
    public class SourceTypeDbService :DbServiceReadOnly<SourceType>
    {
        public SourceTypeDbService(IConfiguration config) : base(config)
        {
            Query = "CALL SourceTypeSelectAll()";
        }
    }
}
