using JupiterWeb.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;

    public class ReadStudentSubjectDTO
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StudentId { get; set; }
    [Required]
    public string? StudentName { get; set; }

    [Required]
    [RegularExpression(@"^\d{14}$")]
    [Column(TypeName = "VARCHAR")]
    [StringLength(14)]
    [Obsolete]
    public string? NationalId { get; set; }


    [Required]

    public String? CurrentAcademicYear { get; set; }

    public ICollection<TotalGrades>? TotalGrades { get; set; }
    public ICollection<StudentSubject>? StudentSubjects { get; set; }
}

