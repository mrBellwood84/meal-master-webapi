using Application.DataService;
using Domain.Messures;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers.Messures
{
    [Route("api/[controller]")]
    public class MessureController : ReadAllOnlyController<Messure>
    {
        public MessureController(IDataServiceReadAllOnly<Messure> dataService) 
            : base(dataService) { }
    }
}
