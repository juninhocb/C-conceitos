using Logistica.mercadorias.Data;
using Logistica.mercadorias.Interfaces;
using Logistica.mercadorias.Models;

namespace Logistica.mercadorias.Repositories
{
    public class CategoryRepository : BaseRepository<CategoryModel>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
