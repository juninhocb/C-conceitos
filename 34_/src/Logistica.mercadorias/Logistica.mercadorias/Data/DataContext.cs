using Logistica.mercadorias.Models;
using Microsoft.EntityFrameworkCore;

namespace Logistica.mercadorias.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){    
        }

        DbSet<ProductModel> Products { get; set; }   
        DbSet<CategoryModel> Categories { get; set; }    
        DbSet<ClientModel> Clients { get; set; } 

    }
}
