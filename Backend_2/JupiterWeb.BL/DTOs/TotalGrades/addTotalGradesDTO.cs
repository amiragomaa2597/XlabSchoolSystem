using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;
    public class addTotalGradesDTO
    {

         
            public int StudentId { get; set; }

            public string? AcademicYear { get; set; }

           
            public string? Year { get; set; }

            
            public int Term1Grade { get; set; }

            
            public int Term2Grade { get; set; }

            

    
        }

