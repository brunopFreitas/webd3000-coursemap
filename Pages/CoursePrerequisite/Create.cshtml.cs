using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_CoursePrerequisite
{
    public class CreateModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public CreateModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "CourseCode");
        ViewData["PrerequisiteId"] = new SelectList(_context.Courses, "Id", "CourseCode");
            return Page();
        }

        [BindProperty]
        public CoursePrerequisite CoursePrerequisite { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CoursePrerequisites == null || CoursePrerequisite == null)
            {
                return Page();
            }

            _context.CoursePrerequisites.Add(CoursePrerequisite);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
