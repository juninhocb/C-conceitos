using Agenda_Contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Contatos.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }

        public DbSet<ContactModel> Contacts { get; set; }

    }
}
