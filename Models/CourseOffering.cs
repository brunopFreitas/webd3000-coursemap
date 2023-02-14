using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Table("CourseOfferings")]
[Index(nameof(CourseOffering.CourseId), 
nameof(CourseOffering.InstructorId),  
nameof(CourseOffering.DiplomaYearSectionId), 
nameof(CourseOffering.SemesterId),  
IsUnique = true)]
public class CourseOffering {

// Scalar Properties - Columns
    public int Id { get; set; }

    [Required]
    public int? CourseId { get; set; }
    
    public int? InstructorId { get; set; }

    [Required]
    public int? DiplomaYearSectionId { get; set; }

    [Required]
    public int? SemesterId { get; set; }

    [Required]
    public Boolean? IsDirectedElective { get; set; } = false!;

// Navigation Properties

    [ForeignKey("CourseId")]
    public Course? Course {get; set;}  = null!;

    [ForeignKey("InstructorId")]
    public Instructor? Instructor {get; set;} = null!;

    [ForeignKey("DiplomaYearSectionId")]
    public DiplomaYearSection? DiplomaYearSection {get; set;} = null!;

    [ForeignKey("SemesterId")]
    public Semester? Semester {get; set;} = null!;

}