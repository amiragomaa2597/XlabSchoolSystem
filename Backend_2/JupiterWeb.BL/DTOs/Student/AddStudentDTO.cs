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
    public class AddStudentDTO
    {
    
    [Required]
    public string? StudentName { get; set; }

    [Required]
    [RegularExpression(@"^\d{14}$")]
    public string? NationalId { get; set; }


    [Required]

    public String? CurrentAcademicYear { get; set; }

   
}

