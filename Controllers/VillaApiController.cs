using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaApi")] // "api/[controller]" can be also used 
    [ApiController] //atribute that notifies the app that this gonna be a controller
    public class VillaApiController : ControllerBase // derives from ControllerBase class
    {
      [HttpGet]
      public IEnumerable<Villa> GetVillas() // the interface in c#
        {
            return new List<Villa>
            {
                new Villa{Id=1, Name="Poll View"},
                new Villa{Id=2, Name="Beach View"}
            };
        }
    }
}
 