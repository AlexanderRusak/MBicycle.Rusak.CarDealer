using CarDealer.BusinessLogic.Dtos;

namespace CarDealer.BusinessLogic
{
    public interface IAllDealersCarService
    {
     IEnumerable<CarDealerDto> GetAllDealersCar();
    }
}
