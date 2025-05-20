using Application.DataService;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Messures
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessureController : BaseReadOnlyController<Messure>
    {
        public MessureController(IDataServiceReadOnly<Messure> dataService)
            : base(dataService) { }
    }
}
