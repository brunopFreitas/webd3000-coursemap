using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_Diploma
{
    public class DeleteModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DeleteModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Diploma Diploma { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Diplomas == null)
            {
                return NotFound();
            }

            var diploma = await _context.Diplomas.FirstOrDefaultAsync(m => m.Id == id);

            if (diploma == null)
            {
                return NotFound();
            }
            else 
            {
                Diploma = diploma;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Diplomas == null)
            {
                return NotFound();
            }
            var diploma = await _context.Diplomas.FindAsync(id);

            if (diploma != null)
            {
                Diploma = diploma;
                _context.Diplomas.Remove(Diploma);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
