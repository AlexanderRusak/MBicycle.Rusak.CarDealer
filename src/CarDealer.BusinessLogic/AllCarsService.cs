using CarDealer.BusinessLogic.Dtos;
using CarDealer.DataAccess.Model.Repositories.Interfaces;

namespace CarDealer.BusinessLogic
{
    internal class AllCarsService : IAllCarsService
    {
        private readonly ICarRepository _carRepository;

        public AllCarsService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IEnumerable<CarDto> GetAllCars()
        {
            var result = _carRepository.Get().Select(car => new CarDto
            {
                Id = car.Id,
                Brand = car.Brand.Name,
                Model = car.Model,
                Color = car.Color.Name
            });
            return result;
        }
    }
}
