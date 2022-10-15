using CarDealer.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class DealerCarRepository : IRepository<DealerCar>
    {

        private readonly CarDealerContext _context;

        public DealerCarRepository(CarDealerContext context)
        {
            _context = context;
        }
        public DealerCar Add(DealerCar item)
        {
            var result = _context.DealerCars.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(DealerCar item)
        {
            _context.DealerCars.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {

            var dealerCar = new DealerCar { Id = id };
            _context.DealerCars.Attach(dealerCar);
            Delete(dealerCar);
        }

        public ICollection<DealerCar> Get()
        {
            return _context.DealerCars.ToList();
        }

        public DealerCar Get(int id)
        {
            var result = _context.DealerCars.Where(dealerCar => dealerCar.Id == id).FirstOrDefault();
            return result ??= new DealerCar();
        }

        public void Update(DealerCar item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
