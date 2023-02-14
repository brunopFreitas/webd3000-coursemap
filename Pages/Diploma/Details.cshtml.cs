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
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public Diploma Diploma { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Diplomas == null)
            {
                return NotFound();
            }

            var diploma = await _context.Diplomas
                .Include(d => d.DiplomaYears)
            .FirstOrDefaultAsync(m => m.Id == id);
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
    }
}
