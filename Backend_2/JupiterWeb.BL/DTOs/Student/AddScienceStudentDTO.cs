using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;
    public class AddScienceStudentDTO
    {
   
    public int StudentId { get; set; }
    
    public int? Term1Science { get; set; }
    public int? Term2Science { get; set; }
}

