using CarDealer.BusinessLogic;
using CarDealer.BusinessLogic.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.WebApi.Controllers
{
    [ApiController]
    [Route("api/car")]
    public class CarController : ControllerBase
    {
        private readonly IAllCarsService _car;

        public CarController(IAllCarsService car)
        {
            _car = car ?? throw new ArgumentNullException(nameof(car));
        }

        [HttpGet("all")]

        public IEnumerable<CarDto> Get()
        {
            return _car.GetAllCars();
        }

        [HttpPost]

        public void Post() { }

    }
}
