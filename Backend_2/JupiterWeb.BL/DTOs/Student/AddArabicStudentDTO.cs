using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;
    public class AddArabicStudentDTO
    {
    public int StudentId { get; set; }
    
    public int? Term1Arabic { get; set; }
    public int? Term2Arabic { get; set; }
   
}

