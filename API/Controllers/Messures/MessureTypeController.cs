using Application.DataService.Interfaces;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Messures
{
    [Route("api/messure/type")]
    [ApiController]
    public class MessureTypeController : BaseReadOnlyDisabled<MessureType>
    {
        public MessureTypeController(IDataServiceReadOnly<MessureType> dataService)
            : base(dataService) { }
    }
}
