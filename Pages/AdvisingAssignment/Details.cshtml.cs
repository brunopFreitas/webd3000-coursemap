using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_AdvisingAssignment
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public AdvisingAssignment AdvisingAssignment { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AdvisingAssignments == null)
            {
                return NotFound();
            }

            var advisingassignment = await _context.AdvisingAssignments
                .Include(aa => aa.Instructor)
                .Include(aa => aa.DiplomaYearSection.DiplomaYear.Diploma)
            .FirstOrDefaultAsync(m => m.Id == id);
            if (advisingassignment == null)
            {
                return NotFound();
            }
            else 
            {
                AdvisingAssignment = advisingassignment;
            }
            return Page();
        }
    }
}
