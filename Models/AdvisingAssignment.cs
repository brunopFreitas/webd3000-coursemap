using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Table("AdvisingAssignments")]
[Index(nameof(AdvisingAssignment.InstructorId), 
nameof(AdvisingAssignment.DiplomaYearSectionId), 
IsUnique = true)]
public class AdvisingAssignment {

// Scalar Properties - Columns
    public int Id { get; set; }

    [Required]
    public int InstructorId { get; set; }

    [Required]
    public int DiplomaYearSectionId { get; set; }

// Navigation Properties

    [ForeignKey("InstructorId")]
    public Instructor Instructor { get; set; } = null!;

    [ForeignKey("DiplomaYearSectionId")]
    public DiplomaYearSection DiplomaYearSection { get; set; } = null!;

}