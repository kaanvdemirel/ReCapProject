using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CarRentalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
       

        public CarsController(ICarService carService)
        {
                _carService = carService;
            
        }
       

        [HttpGet("getall")]   

        public IActionResult Get() {


            var result = _carService.GetAll();

            if (result.Success) {

                return Ok(result);
            
            }

            return BadRequest(result);  

        
        }


        [HttpPost("addcar")]

        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);

            if (result.Success)
            {

                return Ok(result);  
            }

            return BadRequest(result);    
        }
        
    }
}
