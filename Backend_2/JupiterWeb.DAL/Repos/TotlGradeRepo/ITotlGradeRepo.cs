using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;
    public interface ITotlGradeRepo :IGeneralRepo<TotalGrades>
    {
    Task<IEnumerable<TotalGrades>> GetByStudentId(int studentId);
}

