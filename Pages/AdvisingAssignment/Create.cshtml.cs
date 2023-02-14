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
    public class CreateModel : PageModel
    {
        private readonly w0448225CourseMap.Data.w0448225CourseMapContext _context;

        public CreateModel(w0448225CourseMap.Data.w0448225CourseMapContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

        var instructorList = _context.Instructors.ToList();
        // He created a view folder for this, instead of creating this class here
        var instructorDropdownList = new List<InstructorForDropdown>();
        instructorDropdownList.Add(new InstructorForDropdown(){
            Id=null,
            FullName="No Instructor Selected"
        });
        // Add the rest of the date looping through instructor
        instructorList.ForEach(instructor => {
            instructorDropdownList.Add(new InstructorForDropdown(){
                Id=instructor.Id,
                FullName=instructor.FullName
            });
        });


        ViewData["InstructorId"] = new SelectList(instructorDropdownList, "Id", "FullName");
            return Page();
        }

        [BindProperty]
        public AdvisingAssignment AdvisingAssignment { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.AdvisingAssignments == null || AdvisingAssignment == null)
            {
                return Page();
            }

            _context.AdvisingAssignments.Add(AdvisingAssignment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

    public class InstructorForDropdown {
        public int? Id {get; set; }
        public string? FullName { get; set; }
    }
