using CarDealer.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class CarModelRepository : IRepository<CarModel>


    {

        private readonly CarDealerContext _context;
        public CarModelRepository(CarDealerContext context)
        {
            _context = context;
        }
        public CarModel Add(CarModel item)
        {
            var result = _context.CarModels.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(CarModel item)
        {
            _context.CarModels.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var carModel = new CarModel { Id = id };
            _context.CarModels.Attach(carModel);
            Delete(carModel);
        }

        public ICollection<CarModel> Get()
        {
            return _context.CarModels.ToList();
        }

        public CarModel Get(int id)
        {
            var result = _context.CarModels.Where(carModel => carModel.Id == id).FirstOrDefault();
            return result ??= new CarModel();
        }

        public void Update(CarModel item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
