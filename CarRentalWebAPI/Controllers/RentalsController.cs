using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
                _rentalService = rentalService;
        }
        [HttpPost("rent")] 
        
        public IActionResult Rental(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success) {

                return Ok(result);
                
               
                
                

            
            
            
            
            }
            return BadRequest(result);

        }

            

    }
}
