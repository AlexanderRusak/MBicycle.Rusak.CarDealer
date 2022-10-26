using CarDealer.BusinessLogic.Dtos;
using CarDealer.DataAccess.Model.Repositories.Interfaces;

namespace CarDealer.BusinessLogic
{
    public class AllDealersCarService : IAllDealersCarService
    {
        private readonly IDealerCarRepository _dealerCarRepository;

        public AllDealersCarService(IDealerCarRepository dealerCarRepository)
        {
            _dealerCarRepository = dealerCarRepository ?? throw new ArgumentNullException(nameof(dealerCarRepository));
        }

        public IEnumerable<CarDealerDto> GetAllDealersCar()
        {
            var result = _dealerCarRepository.Get().Select(dealerCar =>
            new CarDealerDto
            {
                Id = dealerCar.Id,
                Brand = dealerCar.Car.Brand.Name,
                Model = dealerCar.Car.Model,
                Color = dealerCar.Car.Color.Name,
                DealerName = dealerCar.Dealer.Name,
                DealerPhone = dealerCar.Dealer.Phone,
                Price = dealerCar.Price,
            }
            );

            return result;
        }
    }
}
