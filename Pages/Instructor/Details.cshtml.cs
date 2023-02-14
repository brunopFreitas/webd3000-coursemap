using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_Instructor
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public Instructor Instructor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Instructors == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .Include(i => i.AdvisingAssignments)
                    .ThenInclude( aa => aa.DiplomaYearSection)
                        .ThenInclude(dys => dys.AcademicYear)
                            .ThenInclude(ay => ay.Semester)
                .Include(i => i.AdvisingAssignments)
                    .ThenInclude( aa => aa.DiplomaYearSection)
                        .ThenInclude(dys => dys.DiplomaYear)
                            .ThenInclude(dy => dy.Diploma)
            .FirstOrDefaultAsync(m => m.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }
            else 
            {
                Instructor = instructor;
            }
            return Page();
        }
    }
}
