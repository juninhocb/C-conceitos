using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesMsft.Models;

namespace MoviesMsft.Data
{
    public class MoviesMsftContext : DbContext
    {
        public MoviesMsftContext (DbContextOptions<MoviesMsftContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesMsft.Models.MovieModel> MovieModel { get; set; } = default!;
    }
}
