using JupiterWeb.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;
public class StudentRepo : IStudentRepo
{
    private readonly SchoolDbContext _context;

    public StudentRepo(SchoolDbContext context)
    {
        _context = context;
    }
    public async Task Add(Student entity)
    {
        await _context.Students.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Student entity)
    {
        _context.Students.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Edit(int studentId, Student updatedStudent)
    {

        var existingStudent = await _context.Students.FindAsync(studentId);
        if (existingStudent == null)
        {
            throw new ArgumentException("Student not found");
        }

        // Update the properties of the existing student with the values from the updated student
        existingStudent.StudentName = updatedStudent.StudentName;
        existingStudent.NationalId = updatedStudent.NationalId;
        existingStudent.CurrentAcademicYear = updatedStudent.CurrentAcademicYear;
        // Update other properties as needed

        await _context.SaveChangesAsync();

    }

    public async Task EditScience(int studentId, Student updatedStudent)
    {

        var existingStudent = await _context.Students.FindAsync(studentId);
        if (existingStudent == null)
        {
            throw new ArgumentException("Student not found");
        }

        // Update the properties of the existing student with the values from the updated student
        existingStudent.Term1Science = updatedStudent.Term1Science;
        existingStudent.Term2Science = updatedStudent.Term2Science;
        

        await _context.SaveChangesAsync();

    }

    public async Task EditArabic(int studentId, Student updatedStudent)
    {

        var existingStudent = await _context.Students.FindAsync(studentId);
        if (existingStudent == null)
        {
            throw new ArgumentException("Student not found");
        }

        // Update the properties of the existing student with the values from the updated student
        existingStudent.Term1Arabic = updatedStudent.Term1Arabic;
        existingStudent.Term2Arabic = updatedStudent.Term2Arabic;
        

        await _context.SaveChangesAsync();

    }

    public async Task<IEnumerable<Student>> GetAll()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetById(int id)
    {
        return await _context.Students.FindAsync(id);
    }

  
    public async Task<IEnumerable<Student>> GetByNationalId(string nationalId)
    {
        return await _context.Students.Where(s => s.NationalId == nationalId).ToListAsync();
    }

    
}

