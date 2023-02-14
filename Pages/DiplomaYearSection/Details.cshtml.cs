using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_DiplomaYearSection
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public DiplomaYearSection DiplomaYearSection { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DiplomaYearSections == null)
            {
                return NotFound();
            }

            var diplomayearsection = await _context.DiplomaYearSections.FirstOrDefaultAsync(m => m.Id == id);
            if (diplomayearsection == null)
            {
                return NotFound();
            }
            else 
            {
                DiplomaYearSection = diplomayearsection;
            }
            return Page();
        }
    }
}
