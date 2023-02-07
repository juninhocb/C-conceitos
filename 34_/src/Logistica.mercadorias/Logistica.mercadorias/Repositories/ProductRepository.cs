using Logistica.mercadorias.Data;
using Logistica.mercadorias.Interfaces;
using Logistica.mercadorias.Models;

namespace Logistica.mercadorias.Repositories
{
    public class ProductRepository : BaseRepository<ProductModel>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
