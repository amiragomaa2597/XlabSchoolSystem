using JupiterWeb.BL;
using JupiterWeb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace JupiterWeb.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManger _studentManager;

        public StudentController(IStudentManger studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _studentManager.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await _studentManager.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpGet("national/{nationalId}")]
        public async Task<ActionResult<Student>> GetStudentByNationalId(string NationalId)
        {
            var students = await _studentManager.GetAllStudents();
            return Ok(students);
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(AddStudentDTO studentDTO)
        {
            await _studentManager.AddStudent(studentDTO);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            await _studentManager.DeleteStudent(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditStudent(int id, AddStudentDTO student)
        {
            await _studentManager.EditStudent(id, student);
            return Ok();
        }

        [HttpPut("Arabic/{id}/{term1}/{term2}")]
        public async Task<ActionResult> EditArabic(int id, int term1 , int term2)
        {
            var student = new AddArabicStudentDTO()
            {
                Term1Arabic = term1,
                Term2Arabic = term2,
            };
            await _studentManager.EditArabic(id, student);
            return Ok();
        }


        [HttpPut("Science/{id}/{term1}/{term2}")]
        public async Task<ActionResult> EditScience(int id, int term1, int term2)
        {
            var student = new AddScienceStudentDTO()
            {
                Term1Science = term1,
                Term2Science = term2,
            };
            await _studentManager.EditScience(id, student);
            return Ok();
        }
    }
}