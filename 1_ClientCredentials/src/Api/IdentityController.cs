using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace Api
{
    [Route("identity")]
    /*[Authorize("ApiScope2")]*/
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() {
            return new JsonResult(
                from c in User.Claims 
                select new {c.Type,c.Value}
            );
        }
    }
}