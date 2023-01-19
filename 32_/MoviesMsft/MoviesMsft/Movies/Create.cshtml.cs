using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesMsft.Data;
using MoviesMsft.Models;

namespace MoviesMsft.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MoviesMsft.Data.MoviesMsftContext _context;

        public CreateModel(MoviesMsft.Data.MoviesMsftContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MovieModel MovieModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.MovieModel == null || MovieModel == null)
            {
                return Page();
            }

            _context.MovieModel.Add(MovieModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
