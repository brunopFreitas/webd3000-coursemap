using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_DiplomaYear
{
    public class CreateModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public CreateModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DiplomaId"] = new SelectList(_context.Diplomas, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public DiplomaYear DiplomaYear { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DiplomaYears == null || DiplomaYear == null)
            {
                return Page();
            }

            _context.DiplomaYears.Add(DiplomaYear);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
