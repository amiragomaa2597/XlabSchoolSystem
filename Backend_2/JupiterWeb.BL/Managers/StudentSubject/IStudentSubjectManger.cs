using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;


public interface IStudentSubjectsManger
{
    Task<IEnumerable<StudentSubject>> GetAllStudentSubjects();
    Task<StudentSubject> GetStudentSubjectById(int id);

    Task<IEnumerable<StudentSubject>> GetStudentSubjectByStudentId(int id);

    Task<IEnumerable<StudentSubject>> GetStudentSubjectBySubjectId(int id);
    Task AddStudentSubject(addStudentSubjectDTO studentDTO);
    Task DeleteStudentSubject(int id);
}
