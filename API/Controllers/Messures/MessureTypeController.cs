using Application.DataService;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Messures
{
    [Route("api/messure/type")]
    public class MessureTypeController : ReadAllOnlyController<MessureType>
    {
        public MessureTypeController(IDataServiceReadAllOnly<MessureType> dataService) 
            : base(dataService) { }
    }
}
