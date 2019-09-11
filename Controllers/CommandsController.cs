using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

#region Notes on Basic API Controllers
// * Inherit from ControllerBase when no view support is needed
// * "api/[controller]" takes name of ControllerClass minus "controller"
#endregion

namespace CmdApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CommandsController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetString()
    {
      return new string[] { "This", "Is", "A", "Hard", "Coded", "Array" };
    }
  }
}