using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

    public class Student
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
    
    public string? NationalId { get; set; }


    [Required]

    public String? CurrentAcademicYear { get; set; }

    public int? Term1Arabic { get; set; }
    public int? Term2Arabic { get; set; }
    public int? Term1Science { get; set; }
    public int? Term2Science { get; set; }
   
    
}

