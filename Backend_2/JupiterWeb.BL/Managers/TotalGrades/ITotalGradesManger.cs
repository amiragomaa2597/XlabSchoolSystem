using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;
    public interface ITotalGradesManger
    {
    Task<IEnumerable<TotalGrades>> GetAllTotalGrades();
    Task<TotalGrades> GetTotalGradeById(int id);

    Task<IEnumerable<TotalGrades>> GetTotalGradeByStudentId(int id);
    Task AddTotalGrade(addTotalGradesDTO studentDTO);
    Task DeleteTotalGrade(int id);
}

