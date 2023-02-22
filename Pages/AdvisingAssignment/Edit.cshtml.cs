using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using w0448225CourseMap.Data;
using w0448225CourseMap.Models;

namespace w0448225CourseMap.Pages_AdvisingAssignment
{
    public class EditModel : PageModel
    {
        private readonly w0448225CourseMap.Data.ApplicationDbContext _context;

        public EditModel(w0448225CourseMap.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AdvisingAssignment AdvisingAssignment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AdvisingAssignments == null)
            {
                return NotFound();
            }

            var advisingassignment =  await _context.AdvisingAssignments.FirstOrDefaultAsync(m => m.Id == id);
            if (advisingassignment == null)
            {
                return NotFound();
            }
            AdvisingAssignment = advisingassignment;
                   ViewData["DiplomaYearSectionId"] = new SelectList(
            (
                from dys in _context.DiplomaYearSections
                .Include(dys => dys.DiplomaYear)
                .ThenInclude(dy => dy.Diploma)
                .ToList()
                select new {
                    Id=dys.Id,
                    Title=dys.DiplomaYear.Diploma.Title + " - " + dys.DiplomaYear.Title + " - " + dys.Title
                }
            ), "Id", "Title");
            
           ViewData["InstructorId"] = new SelectList(_context.Instructors, "Id", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AdvisingAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvisingAssignmentExists(AdvisingAssignment.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AdvisingAssignmentExists(int id)
        {
          return (_context.AdvisingAssignments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
