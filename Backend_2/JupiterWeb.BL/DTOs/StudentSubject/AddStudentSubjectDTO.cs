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
public class addStudentSubjectDTO
{


    [Required]

    public int StudentId { get; set; }

    [Required]

    public int SubjectId { get; set; }


    [Required]
    [Range(0, 30)]
    public int? MarksOfThisSubject { get; set; }

    [Required]
    [Range(1, 2)]
    public int Term { get; set; }




}

