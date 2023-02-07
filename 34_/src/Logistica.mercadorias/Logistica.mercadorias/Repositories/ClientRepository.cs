using Logistica.mercadorias.Data;
using Logistica.mercadorias.Interfaces;
using Logistica.mercadorias.Models;

namespace Logistica.mercadorias.Repositories
{
    public class ClientRepository : BaseRepository<ClientModel>, IClientRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }
    }
}
