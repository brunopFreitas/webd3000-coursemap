using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Index(nameof(Semester.Name), IsUnique = true)]
[Table("Semesters")]
public class Semester {

// Scalar Properties - Columns
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    [Column(TypeName="Date")]
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; }    

    [Required]
    [Column(TypeName="Date")]
    [Display(Name = "End Date")]
    public DateTime EndDate { get; set; }

    [Required]
    public int? AcademicYearId {get; set; }

// Navigation Properties

    [ForeignKey("AcademicYearId")]
    [Display(Name = "Academic Year")]
    public AcademicYear AcademicYear {get; set;} = null!;

    public ICollection<CourseOffering> CourseOfferings {get; set;} = null!;
}