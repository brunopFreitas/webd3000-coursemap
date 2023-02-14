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
    public class IndexModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public IndexModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IList<CourseOffering> CourseOffering { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CourseOfferings != null)
            {
                CourseOffering = await _context.CourseOfferings
                .Include(c => c.Course)
                .Include(c => c.DiplomaYearSection)
                .Include(c => c.DiplomaYearSection.DiplomaYear)
                .Include(c => c.DiplomaYearSection.DiplomaYear.Diploma)
                .Include(c => c.Instructor)
                .Include(c => c.Semester)
                .OrderByDescending(c => c.Semester)
                .OrderBy(c => c.DiplomaYearSection.DiplomaYear.Diploma)
                .OrderBy(c => c.DiplomaYearSection.DiplomaYear)
                .OrderBy(c => c.Course)
                .ToListAsync();
            }
        }
    }
}
