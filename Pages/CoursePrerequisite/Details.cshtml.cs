using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_CoursePrerequisite
{
    public class DetailsModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public DetailsModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

      public CoursePrerequisite CoursePrerequisite { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CoursePrerequisites == null)
            {
                return NotFound();
            }

            var courseprerequisite = await _context.CoursePrerequisites
                .Include(c => c.Course)
                .Include(pr => pr.Prerequisite)
            .FirstOrDefaultAsync(m => m.Id == id);
            if (courseprerequisite == null)
            {
                return NotFound();
            }
            else 
            {
                CoursePrerequisite = courseprerequisite;
            }
            return Page();
        }
    }
}
