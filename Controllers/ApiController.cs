using Microsoft.AspNetCore.Mvc;
using WebApp._1С.SQL.Service;

namespace WebApp._1С.SQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        IServiceAPI ServiceAPI;

        public ApiController(IServiceAPI serviceAPI)
        {
            ServiceAPI = serviceAPI;
        }

        // POST api/<ApiController>
        [HttpPost]
        public IActionResult Post([FromBody] JSONParametrs req)
        {
            var returnList = ServiceAPI.GetData(req);
            if (returnList != null)
                return new ObjectResult(returnList);
            return BadRequest();
        }
    }
}
