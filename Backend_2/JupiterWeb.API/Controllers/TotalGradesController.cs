using JupiterWeb.BL;
using JupiterWeb.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JupiterWeb.API;

[Route("api/[controller]")]
[ApiController]
public class TotalGradesController : ControllerBase
{


    private readonly ITotalGradesManger _TotalGradeManager;
    public TotalGradesController(ITotalGradesManger TotalGradeManager)
    {
        _TotalGradeManager = TotalGradeManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentSubject>>> GetAllTotalGrade()
    {
        var studentSubjects = await _TotalGradeManager.GetAllTotalGrades();
        return Ok(studentSubjects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ReadStudentSubjectDTO>> GetTotalGradeById(int id)
    {
        var TotalGrade = await _TotalGradeManager.GetTotalGradeById(id);
        if (TotalGrade == null)
        {
            return NotFound();
        }

        return Ok(TotalGrade);
    }
    [HttpGet("student/{StudentId}")]
    public async Task<ActionResult<ReadStudentSubjectDTO>> GetTotalGradeByStudentId(int StudentId)
    {
        var TotalGrade = await _TotalGradeManager.GetTotalGradeByStudentId(StudentId);
        if (TotalGrade == null)
        {
            return NotFound();
        }

        return Ok(TotalGrade);
    }



    [HttpPost]
    public async Task<ActionResult> AddStudent(addTotalGradesDTO TotalGradeDTO)
    {
        await _TotalGradeManager.AddTotalGrade(TotalGradeDTO);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteStudent(int id)
    {
        await _TotalGradeManager.DeleteTotalGrade(id);
        return Ok();
    }
}
    



