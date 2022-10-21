using CarDealer.DataAccess.Context;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private readonly CarDealerContext _context;
        public CarRepository(CarDealerContext context)
        {
            _context = context;
        }
        public Car Add(Car item)
        {
            var result = _context.Cars.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(Car item)
        {
            _context.Cars.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var carModel = new Car { Id = id };
            _context.Cars.Attach(carModel);
            Delete(carModel);
        }

        public ICollection<Car> Get()
        {
            return _context.Cars.ToList();
        }

        public Car Get(int id)
        {
            var result = _context.Cars.Where(carModel => carModel.Id == id).FirstOrDefault();
            return result ??= new Car();
        }

        public void Update(Car item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
