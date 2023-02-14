using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_CourseOffering
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public CourseOffering CourseOffering { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CourseOfferings == null)
            {
                return NotFound();
            }

            var courseoffering = await _context.CourseOfferings
                .Include(co => co.DiplomaYearSection)
                .Include(co => co.DiplomaYearSection.DiplomaYear)
                .Include(co => co.DiplomaYearSection.DiplomaYear.Diploma)
                .Include(co => co.Instructor)
                .Include(co => co.Course)
                .Include(co => co.Semester)
            .FirstOrDefaultAsync(m => m.Id == id);
            if (courseoffering == null)
            {
                return NotFound();
            }
            else 
            {
                CourseOffering = courseoffering;
            }
            return Page();
        }
    }
}
