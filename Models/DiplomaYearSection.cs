using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Index(nameof(DiplomaYearSection.Title), 
nameof(DiplomaYearSection.DiplomaYearId),  
nameof(DiplomaYearSection.AcademicYearId), 
IsUnique = true)]
[Table("DiplomaYearSections")]
public class DiplomaYearSection {
    // Scalar properties

    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^[Section]+ [1-9]$")]
    public string? Title { get; set; }

    [Required]
    public int DiplomaYearId { get; set; }

    [Required]
    public int AcademicYearId { get; set; }

    // Navigation Properties

    [ForeignKey("DiplomaYearId")]
    public DiplomaYear DiplomaYear { get; set; } = null!;

    [ForeignKey("AcademicYearId")]
    public AcademicYear AcademicYear { get; set; } = null!;

    public ICollection<CourseOffering> CourseOfferings {get; set;} = null!;

    public AdvisingAssignment AdvisingAssignment { get; set; } = null!;


}