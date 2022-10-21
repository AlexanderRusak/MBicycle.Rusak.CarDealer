namespace CarDealer.DataAccess.Model.Repositories.Interfaces.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity item);
        void Delete(TEntity item);
        void Delete(int id);
        void Update(TEntity item);
        ICollection<TEntity> Get();
        TEntity Get(int id);

    }
}
