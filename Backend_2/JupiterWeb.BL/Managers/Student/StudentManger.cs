using JupiterWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.BL;

public class StudentManger : IStudentManger
{
    private readonly IStudentRepo _studentRepo;

    public StudentManger(IStudentRepo studentRepo)
    {
        _studentRepo = studentRepo;
    }

    public async  Task AddStudent(AddStudentDTO studentDTO)
    {
        var student = new Student
        {
            StudentName = studentDTO.StudentName,
            NationalId = studentDTO.NationalId,
            CurrentAcademicYear = studentDTO.CurrentAcademicYear



        };

        await _studentRepo.Add(student);
    }

    public async Task DeleteStudent(int id)
    {
        var student = await _studentRepo.GetById(id);
        if (student != null)
        {
            await _studentRepo.Delete(student);
        }
    }

    public async Task EditStudent(int id, AddStudentDTO studentToBeEdited)
    {
        var student = new Student()
        {
            StudentName = studentToBeEdited.StudentName,
            NationalId = studentToBeEdited.NationalId,
            CurrentAcademicYear = studentToBeEdited.CurrentAcademicYear,
        };

        await _studentRepo.Edit(id, student);
    }

    public async Task EditArabic(int id , AddArabicStudentDTO student)
    {
        var _student = new Student()
        {
            Term1Arabic = student.Term1Arabic,
            Term2Arabic = student.Term2Arabic,

        };

        await _studentRepo.EditArabic(id, _student);
    }
    public async Task EditScience(int id, AddScienceStudentDTO student)
    {
        var _student = new Student()
        {
            Term1Science = student.Term1Science,
            Term2Science = student.Term2Science,

        };

        await _studentRepo.EditScience(id, _student);
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        var students = await _studentRepo.GetAll();

          return students;
    }

    public async Task<Student> GetStudentById(int id)
    {
        var student = await _studentRepo.GetById(id);
          return student;
    }

    public async Task<IEnumerable<Student> >GetStudentByNationalId(string NationalId)
    {
        return await _studentRepo.GetByNationalId(NationalId);
    }
}










