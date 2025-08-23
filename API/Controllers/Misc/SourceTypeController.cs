using Application.DataService.Interfaces;
using Domain.Misc;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Misc
{
    [Route("api/[controller]")]
    [ApiController]
    public class SourceTypeController : BaseReadOnlyDisabled<SourceType>
    {
        public SourceTypeController(IDataServiceReadOnly<SourceType> dataService)
            : base(dataService) { }
    }
}
