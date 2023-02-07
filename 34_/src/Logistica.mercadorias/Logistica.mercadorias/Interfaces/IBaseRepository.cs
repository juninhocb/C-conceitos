namespace Logistica.mercadorias.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class 
    {
        TEntity FindById(int id);
        List<TEntity> FindAll();
        int Save(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
    }
}
