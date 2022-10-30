using CarDealer.BusinessLogic;
using CarDealer.BusinessLogic.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.WebApi.Controllers
{
    [ApiController]
    [Route("api/car-dealer")]
    public class CarDealerController : ControllerBase
    {


        private readonly IAllDealersCarService _carDealer;


        public CarDealerController(IAllDealersCarService carDealer)
        {
            _carDealer = carDealer ?? throw new ArgumentNullException(nameof(carDealer));
        }

        [HttpGet("all")]
        public IEnumerable<CarDealerDto> Get()
        {
            return _carDealer.GetAllDealersCar();

        }
        [HttpPost]
        public void Post() { }
    }
}