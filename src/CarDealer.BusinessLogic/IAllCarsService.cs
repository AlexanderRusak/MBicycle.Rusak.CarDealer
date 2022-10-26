using CarDealer.BusinessLogic.Dtos;

namespace CarDealer.BusinessLogic
{
    public interface IAllCarsService
    {
        IEnumerable<CarDto> GetAllCars();
    }
}
