using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_DiplomaYear
{
    public class DeleteModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DeleteModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        [BindProperty]
      public DiplomaYear DiplomaYear { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DiplomaYears == null)
            {
                return NotFound();
            }

            var diplomayear = await _context.DiplomaYears.FirstOrDefaultAsync(m => m.Id == id);

            if (diplomayear == null)
            {
                return NotFound();
            }
            else 
            {
                DiplomaYear = diplomayear;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DiplomaYears == null)
            {
                return NotFound();
            }
            var diplomayear = await _context.DiplomaYears.FindAsync(id);

            if (diplomayear != null)
            {
                DiplomaYear = diplomayear;
                _context.DiplomaYears.Remove(DiplomaYear);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
