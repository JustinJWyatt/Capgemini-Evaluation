using Microsoft.AspNetCore.Mvc;

namespace Capgemini.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        // POST: api/Bill
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
