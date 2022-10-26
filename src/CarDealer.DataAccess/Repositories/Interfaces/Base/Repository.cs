

using CarDealer.DataAccess.Context;
using CarDealer.DataAccess.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.DataAccess.Model.Repositories.Interfaces.Base
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {

        public readonly DbContext _context;
        public Repository(DbContext context)
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
            _context.Set<T>().Attach(entity);
            Delete(entity);
        }

        virtual public ICollection<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            var result = _context.Set<T>()
                .FirstOrDefault(x => x.Id == id);
            result ??= CreateEntity(0);
            return result;
        }

        public void Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges(true);
        }

        protected abstract T CreateEntity(int id);
    }
}
