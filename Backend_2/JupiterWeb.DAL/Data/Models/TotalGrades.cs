using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

    public class TotalGrades
    {
    [Key]
    public int GradeId { get; set; }

    [Required]
    [ForeignKey("Student")]
    public int StudentId { get; set; }

    [Required]
    public string? AcademicYear { get; set; }

    [Required]
    public string? Year { get; set; }

    [Required]
    public int Term1Grade { get; set; }

    [Required]
    public int Term2Grade { get; set; }

    [NotMapped]
    public int TotalGrade
    {
        get
        {
            return Term1Grade + Term2Grade;
        }
    }

   // public Student? Student { get; set; }
}

