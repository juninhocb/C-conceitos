using Microsoft.EntityFrameworkCore;
using Noticias.Models;
using System.Collections.Generic;

namespace Noticias.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<NewsModel> News { get; set; }

    }
}
