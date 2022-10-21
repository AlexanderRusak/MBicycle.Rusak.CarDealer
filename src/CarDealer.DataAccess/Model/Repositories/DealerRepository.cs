using CarDealer.DataAccess.Context;
using CarDealer.DataAccess.Model.Repositories.Interfaces;
using CarDealer.DataAccess.Model.Repositories.Interfaces.Base;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class DealerRepository : Repository<Dealer>, IDealerRepository
    {
        public DealerRepository(CarDealerContext context) : base(context)
        {
        }

        protected override Dealer CreateEntity(int id)
        {
            return new Dealer { Id = id };
        }
    }
}
