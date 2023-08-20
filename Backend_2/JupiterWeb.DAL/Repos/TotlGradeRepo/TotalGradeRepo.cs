using JupiterWeb.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupiterWeb.DAL;

public class TotalGradeRepo : ITotlGradeRepo
{
    private readonly SchoolDbContext _context;


    public TotalGradeRepo(SchoolDbContext context)
    {
        _context = context;
    }
    public async Task Add(TotalGrades entity)
    {
        _context.TotalGrades.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(TotalGrades entity)
    {
        var TotalGrades = await _context.TotalGrades.FindAsync(entity);
        if (TotalGrades != null)
        {
            _context.TotalGrades.Remove(TotalGrades);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<TotalGrades>> GetAll()
    {
        return await _context.TotalGrades.ToListAsync();
    }

    public async Task<TotalGrades> GetById(int id)
    {
        return await _context.TotalGrades.FindAsync(id);
    }

    public async Task<IEnumerable<TotalGrades>> GetByStudentId(int studentId)
    {
        return await _context.TotalGrades.Where(s => s.StudentId == studentId).ToListAsync();
    }
}
