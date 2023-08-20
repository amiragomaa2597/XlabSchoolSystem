using JupiterWeb.BL;
using JupiterWeb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace JupiterWeb.API;

[ApiController]
[Route("api/[controller]")]
public class StudentSubjectController : ControllerBase
{
    private readonly IStudentSubjectsManger _studentSubjectManager;

    public StudentSubjectController(IStudentSubjectsManger studentSubjectManager)
    {
        _studentSubjectManager = studentSubjectManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentSubject>>> GetAllStudents()
    {
        var studentSubjects = await _studentSubjectManager.GetAllStudentSubjects();
        return Ok(studentSubjects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ReadStudentSubjectDTO>> GetStudentById(int id)
    {
        var studentSubject = await _studentSubjectManager.GetStudentSubjectById(id);
        if (studentSubject == null)
        {
            return NotFound();
        }

        return Ok(studentSubject);
    }
    [HttpGet("student/{StudentId}")]
    public async Task<ActionResult<ReadStudentSubjectDTO>> GetStudentByStudentId(int StudentId)
    {
        var studentSubject = await _studentSubjectManager.GetStudentSubjectByStudentId(StudentId);
        if (studentSubject == null)
        {
            return NotFound();
        }

        return Ok(studentSubject);
    }

    
    [HttpGet("subject/{SubjectId}")]
    public async Task<ActionResult<ReadStudentSubjectDTO>> GetStudentBySubjectId(int SubjectId)
    {
        var studentSubject = await _studentSubjectManager.GetStudentSubjectBySubjectId(SubjectId);
        if (studentSubject == null)
        {
            return NotFound();
        }

        return Ok(studentSubject);
    }

    [HttpPost]
    public async Task<ActionResult> AddStudent(addStudentSubjectDTO studentDTO)
    {
        await _studentSubjectManager.AddStudentSubject(studentDTO);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteStudent(int id)
    {
        await _studentSubjectManager.DeleteStudentSubject(id);
        return Ok();
    }
}
