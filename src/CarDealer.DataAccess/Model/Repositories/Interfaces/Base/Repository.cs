

using CarDealer.DataAccess.Context;

namespace CarDealer.DataAccess.Model.Repositories.Interfaces.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        private readonly CarDealerContext _context;
        public Repository(CarDealerContext context)
        {
            _context = context;
        }
        public T Add(T item)
        {
            var result = _context.Set<T>().Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = CreateEntity(id);
            _context.Attach(entity);
            Delete(entity);
        }

        virtual public ICollection<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        protected abstract T CreateEntity(int id);
    }
}
