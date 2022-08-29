using FishKeepingAPI.Data;
using FishKeepingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FishKeepingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishKeepingController : ControllerBase
    {
        private readonly IFishKeepingAPIRepo _repository;
        public FishKeepingController(IFishKeepingAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // return new string[] 
            // {
            //     "Tiger Barb",
            //     "Neon Tetra",
            //     "Zebra Danio"
            // };
            var fishKeepingItems = _repository.GetAllFreshWaterFish();
            return Ok(fishKeepingItems);
        }
    }
}