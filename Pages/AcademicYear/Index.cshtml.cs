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
    public class IndexModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public IndexModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IList<AcademicYear> AcademicYear { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AcademicYears != null)
            {
                AcademicYear = await _context.AcademicYears
                                            .OrderByDescending(y => y.Title)
                                            .ToListAsync();
            }
        }
    }
}
