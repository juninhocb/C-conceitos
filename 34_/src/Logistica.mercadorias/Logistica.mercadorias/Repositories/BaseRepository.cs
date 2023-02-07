using Logistica.mercadorias.Data;
using Logistica.mercadorias.Interfaces;

namespace Logistica.mercadorias.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            TEntity obj = FindById(id);
            if (obj == null) throw new Exception("Erro ao encontrar a entidade"); 
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return _context.Set<TEntity>().ToList(); 
        }

        public TEntity FindById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public int Save(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            return _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Update(obj);
                _context.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception("Não foi possível altrerar os dados. Err: " + ex.Message);
            }
        }
    }
}
