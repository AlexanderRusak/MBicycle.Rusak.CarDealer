using CarDealer.DataAccess.Context;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class ColorRepositiry : IRepository<Color>
    {

        private readonly CarDealerContext _context;
        public ColorRepositiry(CarDealerContext context)
        {
            _context = context;
        }
        public Color Add(Color item)
        {
            var result = _context.Colors.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(Color item)
        {
            _context.Colors.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var color = new Color { Id = id };
            _context.Colors.Attach(color);
            Delete(color);

        }

        public ICollection<Color> Get()
        {
            return _context.Colors.ToList();
        }

        public Color Get(int id)
        {
            var result = _context.Colors.Where(color => color.Id == id).FirstOrDefault();
            return result ??= new Color();

        }

        public void Update(Color item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
