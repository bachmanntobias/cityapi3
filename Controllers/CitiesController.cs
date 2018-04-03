using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Controllers
{

    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        //[HttpGet("api/[controller]")]
        public  IActionResult GetCities()

        {
            return Ok(CitiesDataStore.Current.Cities);
        }


        [HttpGet("{id}")]

        public IActionResult GetCity(int id)
            {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
                
                
        }
    }
}
