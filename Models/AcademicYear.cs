using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Index(nameof(AcademicYear.Title), IsUnique = true)]
[Table("AcademicYears")]
public class AcademicYear {

// Scalar Properties - Columns
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^.{5,20}$")]
    public string? Title { get; set; }    

// Navigation Properties

    public ICollection<DiplomaYearSection>? DiplomaYearSection {get; set;}  

    public ICollection<Semester>? Semester {get; set;}   


}