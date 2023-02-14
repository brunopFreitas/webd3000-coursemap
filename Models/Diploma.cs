using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace w0448225CourseMap.Models;

[Index(nameof(Diploma.Title), IsUnique = true)]
[Table("Diplomas")]
public class Diploma {

// Scalar Properties - Columns
    public int Id { get; set; }

    [Required]
    [RegularExpression(@"^.{10,}$")]
    public string? Title { get; set; }

    

// Navigation Properties

    public ICollection<DiplomaYear> DiplomaYears {get; set;} = null!;    

}