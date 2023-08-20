using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;

public interface IStudentManger
{
    Task<IEnumerable<Student>> GetAllStudents();
    Task<Student> GetStudentById(int id);

    Task<IEnumerable<Student>> GetStudentByNationalId(String National);
    Task AddStudent(AddStudentDTO studentDTO);

    Task EditStudent(int id, AddStudentDTO student);

    Task EditArabic(int id,AddArabicStudentDTO student);
    Task EditScience(int id,AddScienceStudentDTO student);
    Task DeleteStudent(int id);


}
