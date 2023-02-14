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
    public class IndexModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public IndexModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IList<DiplomaYearSection> DiplomaYearSection { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DiplomaYearSections != null)
            {
                DiplomaYearSection = await _context.DiplomaYearSections
                .Include(d => d.AcademicYear)
                .OrderByDescending(d => d.AcademicYear.Title)
                .Include(d => d.DiplomaYear)
                .Include(d => d.DiplomaYear.Diploma)
                .OrderBy(d => d.DiplomaYear.Title)
                .OrderBy(d => d.Title)
                .ToListAsync();
            }
        }
    }
}
