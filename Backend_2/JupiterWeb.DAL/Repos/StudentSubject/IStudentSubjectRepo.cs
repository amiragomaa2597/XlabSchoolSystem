using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

    public interface IStudentSubjectRepo :IGeneralRepo<StudentSubject>
    {
    Task<IEnumerable<StudentSubject>> GetByStudentId(int studentId);
    Task<IEnumerable<StudentSubject>> GetBySubjectId(int subjectId);
}

