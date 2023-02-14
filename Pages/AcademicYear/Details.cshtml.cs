using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_AcademicYear
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public AcademicYear AcademicYear { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AcademicYears == null)
            {
                return NotFound();
            }

            var academicyear = await _context.AcademicYears
                .Include(ay => ay.Semester)
                .Include(ay => ay.DiplomaYearSection)
                    .ThenInclude(dys => dys.AdvisingAssignment)
                        .ThenInclude(aa => aa.Instructor)
                .Include(ay => ay.DiplomaYearSection)
                    .ThenInclude(dys => dys.DiplomaYear)
                        .ThenInclude(dy => dy.Diploma)
                
            .FirstOrDefaultAsync(m => m.Id == id);
            if (academicyear == null)
            {
                return NotFound();
            }
            else 
            {
                AcademicYear = academicyear;
            }
            return Page();
        }
    }
}
