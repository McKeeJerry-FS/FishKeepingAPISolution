using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FishKeepingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishKeepingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] 
            {
                "Tiger Barb",
                "Neon Tetra",
                "Zebra Danio"
            };
        }
    }
}