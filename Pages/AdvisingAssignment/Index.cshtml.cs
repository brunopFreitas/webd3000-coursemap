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
    public class IndexModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public IndexModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IList<AdvisingAssignment> AdvisingAssignment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AdvisingAssignments != null)
            {
                AdvisingAssignment = await _context.AdvisingAssignments
                .Include(a => a.DiplomaYearSection)
                .Include(a => a.DiplomaYearSection.DiplomaYear)
                .Include(a => a.DiplomaYearSection.DiplomaYear.Diploma)
                .Include(a => a.Instructor)
                .OrderBy(d => d.DiplomaYearSection.DiplomaYear.Diploma.Title)
                .OrderBy(d => d.DiplomaYearSection.DiplomaYear.Title)
                .OrderBy(d => d.DiplomaYearSection.Title)
                .ToListAsync();
            }
        }
    }
}
