using CarDealer.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class CarModelNameRepository : IRepository<CarModelName>
    {


        private readonly CarDealerContext _context;
        public CarModelNameRepository(CarDealerContext context)
        {
            _context = context;
        }

        public CarModelName Add(CarModelName item)
        {
            var result = _context.CarModelNames.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(CarModelName item)
        {
            _context.CarModelNames.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var carModelName = new CarModelName { Id = id };
            _context.CarModelNames.Attach(carModelName);
            Delete(carModelName);
        }

        public ICollection<CarModelName> Get()
        {
            return _context.CarModelNames.ToList();
        }

        public CarModelName Get(int id)
        {
            var result = _context.CarModelNames.Where(carModelName => carModelName.Id == id).FirstOrDefault();
            return result ??= new CarModelName();
        }

        public void Update(CarModelName item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
