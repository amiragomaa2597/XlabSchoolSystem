using JupiterWeb.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

public class StudentSubjectRepo : IStudentSubjectRepo
{
    private readonly SchoolDbContext _context;


    public StudentSubjectRepo(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task Add(StudentSubject entity)
    {
        _context.StudentSubjects.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(StudentSubject entity)
    {
        var studentSubject = await _context.StudentSubjects.FindAsync(entity.Id);
        if (studentSubject != null)
        {
            _context.StudentSubjects.Remove(studentSubject);
            await _context.SaveChangesAsync();
        }

    }

    public async Task<IEnumerable<StudentSubject>> GetAll()
    {
        return await _context.StudentSubjects.ToListAsync();
    }

    public async Task<StudentSubject> GetById(int id)
    {
        return await _context.StudentSubjects.FindAsync(id);
    }


    public async Task<IEnumerable<StudentSubject>> GetByStudentId(int studentId)
    {
        return await _context.StudentSubjects.Where(s => s.StudentId == studentId).ToListAsync();
    }


    public async Task<IEnumerable<StudentSubject>> GetBySubjectId(int subjectId)
    {
        return await _context.StudentSubjects.Where(s => s.SubjectId == subjectId).ToListAsync();
    }
}

