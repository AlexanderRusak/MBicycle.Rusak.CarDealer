using CarDealer.DataAccess.Context;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class BrandRepository : IRepository<Brand>
    {


        private readonly CarDealerContext _context;
        public BrandRepository(CarDealerContext context)
        {
            _context = context;
        }

        public Brand Add(Brand item)
        {
            var result = _context.Brands.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(Brand item)
        {
            _context.Brands.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var carModelName = new Brand { Id = id };
            _context.Brands.Attach(carModelName);
            Delete(carModelName);
        }

        public ICollection<Brand> Get()
        {
            return _context.Brands.ToList();
        }

        public Brand Get(int id)
        {
            var result = _context.Brands.Where(brand => brand.Id == id).FirstOrDefault();
            return result ??= new Brand();
        }

        public void Update(Brand item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
