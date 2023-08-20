using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

public class StudentSubject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] 
    [ForeignKey("Student")]
    public int StudentId { get; set; }

    [Required]
    [ForeignKey("Subject")]
    public int SubjectId { get; set; }

    [Required]
    [Range(0, 30)]
    public int? MarksOfThisSubject { get; set; }

    [StringLength(1)]
    [NotMapped]
    public string? GradeState
    {
        get
        {
            if (string.IsNullOrWhiteSpace(MarksOfThisSubject.ToString()))
            {
                return null;
            }

            double gradeValue;
            if (!double.TryParse(MarksOfThisSubject.ToString(), out gradeValue))
            {
                return null;
            }

            if (gradeValue >= 90)
            {
                return "A";
            }
            else if (gradeValue >= 75)
            {
                return "B";
            }
            else if (gradeValue >= 65)
            {
                return "C";
            }
            else if (gradeValue >= 50)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
    [Required]
    [Range(1,2)]
    public int Term { get; set; }


   // public Student? Student { get; set; }
    public Subject? Subject { get; set; }
}
