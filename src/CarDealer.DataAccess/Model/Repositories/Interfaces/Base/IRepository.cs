using CarDealer.DataAccess.Model.Base;

namespace CarDealer.DataAccess.Model.Repositories.Interfaces.Base
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity Add(TEntity item);
        void Delete(TEntity item);
        void Delete(int id);
        void Update(TEntity item);
        ICollection<TEntity> Get();
        TEntity Get(int id);

    }
}
