namespace CarDealer.DataAccess.Model.Repositories
{
    public interface IRepository<TModel>
    {
        TModel Add(TModel item);
        void Delete(TModel item);
        void Delete(int id);
        void Update(TModel item);
        ICollection<TModel> Get();
        TModel Get(int id);

    }
}
