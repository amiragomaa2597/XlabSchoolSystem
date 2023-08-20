using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

    public interface IStudentRepo :IGeneralRepo<Student>
{

    Task<IEnumerable<Student>> GetByNationalId(String NationalId);

    Task Edit(int studentId, Student updatedStudent);
    public Task EditScience(int studentId, Student updatedStudent);

    public Task EditArabic(int studentId, Student updatedStudent);
    
    }
