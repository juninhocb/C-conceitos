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
    public class DeleteModel : PageModel
    {
        private readonly MoviesMsft.Data.MoviesMsftContext _context;

        public DeleteModel(MoviesMsft.Data.MoviesMsftContext context)
        {
            _context = context;
        }

        [BindProperty]
      public MovieModel MovieModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MovieModel == null)
            {
                return NotFound();
            }

            var moviemodel = await _context.MovieModel.FirstOrDefaultAsync(m => m.Id == id);

            if (moviemodel == null)
            {
                return NotFound();
            }
            else 
            {
                MovieModel = moviemodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.MovieModel == null)
            {
                return NotFound();
            }
            var moviemodel = await _context.MovieModel.FindAsync(id);

            if (moviemodel != null)
            {
                MovieModel = moviemodel;
                _context.MovieModel.Remove(MovieModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
