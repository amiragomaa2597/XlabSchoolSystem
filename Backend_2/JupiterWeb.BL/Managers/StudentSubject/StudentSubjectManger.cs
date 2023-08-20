using JupiterWeb.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;

public class StudentSubjectsManger : IStudentSubjectsManger
{
    private readonly IStudentSubjectRepo _studentSubjectRepo;

    public StudentSubjectsManger(IStudentSubjectRepo studentSubjectRepo)
    {
        _studentSubjectRepo = studentSubjectRepo;
    }

    public async Task<IEnumerable<StudentSubject>> GetAllStudentSubjects()
    {
        var studentSubjects = await _studentSubjectRepo.GetAll();

        return studentSubjects;
    }

    public async Task<StudentSubject> GetStudentSubjectById(int id)
    {
        var studentSubject = await _studentSubjectRepo.GetById(id);
        return studentSubject;
    }
    public async Task AddStudentSubject(addStudentSubjectDTO studentSubjectDTO)
    {
        var studentSubject = new StudentSubject
        {
            StudentId = studentSubjectDTO.StudentId,
            SubjectId = studentSubjectDTO.SubjectId,

            MarksOfThisSubject = studentSubjectDTO.MarksOfThisSubject,


            Term = studentSubjectDTO.Term
        };

        await _studentSubjectRepo.Add(studentSubject);
    }


    public async Task DeleteStudentSubject(int id)
    {
        var studentSubject = await _studentSubjectRepo.GetById(id);
        if (studentSubject != null)
        {
            await _studentSubjectRepo.Delete(studentSubject);
        }
    }

    public async Task<IEnumerable<StudentSubject>> GetStudentSubjectByStudentId(int studentId)
    {
        var studentSubjects = await _studentSubjectRepo.GetByStudentId(studentId);

        return studentSubjects;
    }

    public async Task<IEnumerable<StudentSubject>> GetStudentSubjectBySubjectId(int SubjectId)
    {
        var studentSubjects = await _studentSubjectRepo.GetBySubjectId(SubjectId);

        return studentSubjects;
    }
}



