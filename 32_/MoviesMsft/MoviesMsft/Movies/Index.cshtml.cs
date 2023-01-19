using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesMsft.Data;
using MoviesMsft.Models;

namespace MoviesMsft.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesMsft.Data.MoviesMsftContext _context;

        public IndexModel(MoviesMsft.Data.MoviesMsftContext context)
        {
            _context = context;
        }

        public IList<MovieModel> MovieModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MovieModel != null)
            {
                MovieModel = await _context.MovieModel.ToListAsync();
            }
        }
    }
}
