using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;

public class TotalGradeManger : ITotalGradesManger
{
    private readonly ITotlGradeRepo _TotalGradeRepo;

    public TotalGradeManger(ITotlGradeRepo TotalgradeRepo)
    {
        _TotalGradeRepo = TotalgradeRepo;
    }
    public async Task AddTotalGrade(addTotalGradesDTO addTotalGradeDTO)
    {
        var TotalGrade = new TotalGrades
        {
              StudentId  = addTotalGradeDTO.StudentId,
              AcademicYear = addTotalGradeDTO.AcademicYear,
              Year = addTotalGradeDTO.Year,
              Term1Grade = addTotalGradeDTO.Term1Grade,
              Term2Grade = addTotalGradeDTO.Term2Grade
        };

        await _TotalGradeRepo.Add(TotalGrade);
    }

    public async Task DeleteTotalGrade(int id)
    {
        var studentSubject = await _TotalGradeRepo.GetById(id);
        if (studentSubject != null)
        {
            await _TotalGradeRepo.Delete(studentSubject);
        }
    }

    public async Task<IEnumerable<TotalGrades>> GetAllTotalGrades()
    {
        var TotalGrades = await _TotalGradeRepo.GetAll();

        return TotalGrades;
    }

    public async Task<TotalGrades> GetTotalGradeById(int id)
    {
        var TotalGrades = await _TotalGradeRepo.GetById(id);
        return TotalGrades;
    }

    public async Task<IEnumerable<TotalGrades>> GetTotalGradeByStudentId(int studentId)
    {
        var studentSubjects = await _TotalGradeRepo.GetByStudentId(studentId);

        return studentSubjects;
    }
}

